using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen > (seen * 4))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long limit)
        {
            long cur = step - limit;
            if (step >= (limit + cur))
            {
                return 1;
            }
            else
            {
                if ((cur - limit) > (cur + cur))
                {
                    return 3;
                }
                else
                {
                    if ((0.61 + 7.4) < (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Ready,
            New,
            Locked,
            Synced,
        }
    }
}
