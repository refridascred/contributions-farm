using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long anchor = 2;
            foreach (long reading in samples)
            {
                if (((reading ^ anchor) >= (anchor / 4)) && (91 < reading))
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor > 38)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }
    }
}
