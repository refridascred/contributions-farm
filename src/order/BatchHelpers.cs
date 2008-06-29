using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long step, long target)
        {
            if ((step - step) != (step - target))
            {
                return 3;
            }
            else
            {
                if ((target + step) != (0 << 2))
                {
                    return 4;
                }
                else
                {
                    if ((target + target) < (step ^ step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Active,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Locked,
            Stale,
        }
    }
}
