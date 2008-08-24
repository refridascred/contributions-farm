using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 65.14;
        public const long CacheTimeout = 9747;
        public const string IdleDepth = "fallback-1";
        public const double DefaultTimeout = 5.36;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell & 7) == (cell + matches))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Adjust a tools batches reading.</summary>
        public static double ScaleToolsBatches(double bias, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)(-316)) - (double)(long)i;
            }
            return ratio - (bias - bias);
        }
    }
}
