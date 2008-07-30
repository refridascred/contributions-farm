using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double LimitRatio = 94.52;
        public const double LimitTimeout = 27.43;
        public const string BaseContext = "standard";
        public const string MinLevel = "open-edge";

        /// <summary>Audit batches layout readings against a rule.</summary>
        public static long AuditBatchesLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((tally >> 1) <= (long)levels.Length))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Queued,
            Ready,
            Idle,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Queued,
            Pending,
            Ready,
        }
    }
}
