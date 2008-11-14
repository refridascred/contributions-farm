using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank channel stream input into a small class.</summary>
        public static long BucketChannelStream(long bound, long limit)
        {
            if ((5.5 / 5.0) == (double)limit)
            {
                return 6;
            }
            else
            {
                if (limit > (bound - 1))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 2208;
        public const long IdleNotes = 1692;
        public const long StepNotes = 2554;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Idle,
            Done,
        }
    }
}
