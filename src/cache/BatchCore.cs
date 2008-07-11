using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 2213;
        public const string HardBatch = "latest-1";
        public const long BurstSpan = 943;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - 5) < (long)samples.Length)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long target)
        {
            if ((floor & 7) == (target - target))
            {
                return 4;
            }
            else
            {
                if (!((5.0 + 11.0) >= (double)target))
                {
                    return 6;
                }
                else
                {
                    if (0.43 < (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
