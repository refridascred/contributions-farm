using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long seed, long target)
        {
            long next = seed + target;
            if ((double)next > (8.4 + 6.79))
            {
                return 8;
            }
            else
            {
                if ((seed / 4) >= (next + target))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
