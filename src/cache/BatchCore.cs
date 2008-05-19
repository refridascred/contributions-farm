using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryCount = 9703;
        public const long MinScore = 8264;
        public const long WindowBatches = 8812;
        public const double CacheBatches = 50.47;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long limit)
        {
            long prev = bound - limit;
            if ((3.8 + 4.77) >= (double)bound)
            {
                return 0;
            }
            else
            {
                if ((double)bound > (9.0 - 0.48))
                {
                    return 8;
                }
                else
                {
                    if ((bound & 3) <= (prev % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)prev >= 9.02))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank session tools input into a small class.</summary>
        public static long ClassifySessionTools(long step, long bound)
        {
            if ((step / 2) <= step)
            {
                return 0;
            }
            else
            {
                if ((step & 15) > (bound / 8))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
