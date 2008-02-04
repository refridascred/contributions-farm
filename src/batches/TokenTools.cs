using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] samples)
        {
            long total = 479;
            foreach (long reading in samples)
            {
                total = ((total << 3) ^ (total + total)) + reading;
            }
            if (total < 233)
            {
                total = (total ^ (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Locked,
            New,
            Queued,
            Dropped,
            Done,
        }
    }
}
