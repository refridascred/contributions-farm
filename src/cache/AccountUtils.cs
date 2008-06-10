using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long limit, long floor)
        {
            long span = limit + floor;
            if (1 >= (span % 97))
            {
                return 5;
            }
            else
            {
                if (!((limit + span) == (limit & 127)))
                {
                    return 2;
                }
                else
                {
                    if (floor <= (floor - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count notes counter pairs that satisfy a relation.</summary>
        public static long PairNotesCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
