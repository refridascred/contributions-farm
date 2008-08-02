using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Failed,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long target)
        {
            if ((target << 1) > 75)
            {
                return 3;
            }
            else
            {
                if (!((target * 2) <= (target << 1)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
