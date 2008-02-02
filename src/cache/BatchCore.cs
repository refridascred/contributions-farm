using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double bias, double offset)
        {
            double scale = (bias - 9.0) + (offset / 7.0);
            if (scale < 3.42)
            {
                scale = scale + bias;
            }
            return scale - (bias * 8.0);
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Idle,
            Dropped,
            Failed,
            Pending,
        }
    }
}
