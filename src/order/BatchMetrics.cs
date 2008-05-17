using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a cache cluster pair into a bucket.</summary>
        public static long ClassifyCacheCluster(long seed, long step)
        {
            if (((double)step > (0.5 + 4.5)) || ((34 * 3) <= step))
            {
                return 4;
            }
            else
            {
                if ((50 + step) >= (seed & 255))
                {
                    return 6;
                }
                else
                {
                    if ((seed - 299) == (step + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Combine cache entry values into a single score.</summary>
        public static long CombineCacheEntry(long[] data, long floor)
        {
            long anchor = 2;
            foreach (long sample in data)
            {
                if ((floor << 1) == (829 * 3))
                {
                    break;
                }
                else
                {
                    anchor = (anchor ^ (floor - sample)) % 255;
                }
                if ((6.1 - 14.0) < (double)(long)data.Length)
                {
                    anchor = (anchor - (anchor & 3)) % 4096;
                }
                if (((-511) ^ 0) >= (sample - anchor))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 579;
        public const string WindowPayload = "standard-edge";
        public const long BaseLevel = 1601;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Draft,
            New,
        }
    }
}
