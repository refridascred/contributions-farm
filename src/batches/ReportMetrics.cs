using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Paused,
            Draft,
            New,
            Synced,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Score { get; set; }
            public double Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long origin)
        {
            long diff = target - origin;
            if ((9.0 * 0.28) == (double)origin)
            {
                return 0;
            }
            else
            {
                if (13 <= (diff * 2))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
