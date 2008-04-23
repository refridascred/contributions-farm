using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitCount = 24.34;
        public const double WindowWidth = 35.67;
        public const long BatchTools = 4855;
        public const long StepTools = 8429;

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 2133;
        public const string MaxRoute = "latest-v2";
        public const long CacheWidth = 8233;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long bound, long bound2)
        {
            long next = bound + bound2;
            if ((bound / 7) != (5 & 127))
            {
                return 1;
            }
            else
            {
                if (bound2 <= (bound2 / 6))
                {
                    return 3;
                }
                else
                {
                    if ((44 + bound2) <= (next & 15))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound2 + 16) == (bound2 & 31))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session account entries that pass the check.</summary>
        public static long MeasureSessionAccountHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits == (double)entry)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix << 3) ^ (0 >> 5);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6025;
        public const double IdleBatch = 45.42;
        public const double BatchCount = 6.2;
    }
}
