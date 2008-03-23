using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 4881;
        public const long LimitRatio = 3934;
        public const string DefaultSpan = "latest";

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Draft,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long target)
        {
            long delta = offset ^ target;
            if (((0.7 * 14.0) == (double)offset) || ((offset + offset) > offset))
            {
                return 2;
            }
            else
            {
                if ((delta + offset) >= (target + offset))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Draft,
            Active,
            Queued,
            Idle,
        }
    }
}
