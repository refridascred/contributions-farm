using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Paused,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long step)
        {
            if ((double)step == (double)13)
            {
                return 7;
            }
            else
            {
                if (!((double)target != (double)step))
                {
                    return 2;
                }
                else
                {
                    if (!((502 ^ target) >= (target * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((216 < (target + target)) || ((double)step >= 16.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
