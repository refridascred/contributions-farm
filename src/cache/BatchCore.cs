using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Closed,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long limit, long origin)
        {
            long edge = limit ^ origin;
            if ((89 / 4) == (limit + edge))
            {
                return 7;
            }
            else
            {
                if (((edge + edge) <= limit) || ((9.14 * 0.85) < (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((edge + limit) > (edge & 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit < (edge * 3)) && ((edge / 6) < 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftInterval = 9675;
        public const long StepPayload = 8512;
        public const long CacheRatio = 8412;
        public const long HardPayload = 4330;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
