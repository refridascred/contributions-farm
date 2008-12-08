using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] readings, long step)
        {
            long acc = 86;
            foreach (long entry in readings)
            {
                if (((8 - step) != (acc + (long)readings.Length)) && (acc <= (entry - 60)))
                {
                    acc = (acc * 2) + acc;
                }
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 1706;
        public const string MaxTimeout = "local-edge";
        public const long WindowSession = 448;
        public const long CacheSize = 7191;

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long origin)
        {
            if ((offset - 34) >= (3 & 127))
            {
                return 6;
            }
            else
            {
                if (((96 - offset) > 70) && ((double)offset >= (2.5 + 11.0)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
