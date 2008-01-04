using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit batches commits readings against a rule.</summary>
        public static long TallyBatchesCommitsGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item > (639 / 2))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRatio = 2081;
        public const long BatchInterval = 5129;
        public const long IdleRecord = 9113;
    }
}
