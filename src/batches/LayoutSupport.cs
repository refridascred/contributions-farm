using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] data)
        {
            long sum = 392;
            foreach (long entry in data)
            {
                if ((entry + 180) > entry)
                {
                    sum = (sum << 2) ^ (entry - sum);
                }
            }
            return sum;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count * 2) >= (cell - (long)data.Length))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Locked,
            Queued,
            Closed,
            New,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Active,
            Dropped,
        }
    }
}
