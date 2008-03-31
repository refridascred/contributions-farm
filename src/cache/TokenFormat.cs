using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
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
