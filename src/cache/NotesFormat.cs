using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Pending,
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Digest a series of editor metric entries.</summary>
        public static long TotalEditorMetric(long[] data)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if (state <= (state - state))
                {
                    break;
                }
                else
                {
                    state = ((state * 5) + 605) % 4096;
                    state = (state + (sample << 3)) % 101;
                }
                if ((state - state) != (252 >> 1))
                {
                    state = state - (340 + sample);
                }
            }
            return state % 4096;
        }
    }
}
