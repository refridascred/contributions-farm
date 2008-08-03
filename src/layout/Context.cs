using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (((score << 2) ^ ((long)i % 24)) % 97) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!!((double)matches <= (2.63 + 3.1)))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryRatio = "legacy-1";
        public const long BaseTimeout = 2436;
        public const string MinTimeout = "alpha-1";
        public const long LimitBatches = 2862;
        public const double IdleRatio = 30.71;
    }
}
