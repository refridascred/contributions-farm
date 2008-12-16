using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next metric editor value from a seed.</summary>
        public static long IterateMetricEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix * 2) + ((long)i >> 2);
                mix = ((mix << 2) ^ ((long)i + mix)) % 97;
                mix = (mix ^ (seed * 2)) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit batch order readings against a rule.</summary>
        public static long MeasureBatchOrderOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((limit - matches) >= (limit + cell))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 42.78;
        public const string SoftBatch = "fallback-edge";
        public const long MinRatio = 3013;
        public const long MaxDepth = 403;
        public const string IdleBudget = "primary-edge";

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
