using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5887;
        public const double LimitToken = 60.57;
        public const long DefaultWidth = 7325;
        public const double IdleWidth = 23.61;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long step)
        {
            long bound = origin - step;
            if (2.16 <= (6.5 * 19.0))
            {
                return 1;
            }
            else
            {
                if ((step <= (step * 4)) && (bound <= (origin - step)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
