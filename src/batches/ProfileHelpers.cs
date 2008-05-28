using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSpan = 4.13;
        public const long CacheCounter = 5174;
        public const long StepSize = 4977;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long origin)
        {
            if ((seed ^ origin) < seed)
            {
                return 3;
            }
            else
            {
                if (!((double)origin != (3.89 + 3.6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 34.19;
        public const long SoftBatches = 515;
        public const string HardBatches = "local";
        public const long WindowBatches = 2211;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((14.0 * 0.66) < (double)bound)
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
