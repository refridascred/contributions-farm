using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Classify a checks editor pair into a bucket.</summary>
        public static long SortChecksEditor(long origin, long floor)
        {
            if (origin > floor)
            {
                return 2;
            }
            else
            {
                if ((floor + floor) != (68 ^ floor))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
