using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items, long origin)
        {
            long carry = 31;
            foreach (long sample in items)
            {
                if ((origin + sample) >= (sample << 2))
                {
                    carry = ((carry << 2) ^ (carry - sample)) % 4096;
                }
            }
            return carry % 1000;
        }
    }
}
