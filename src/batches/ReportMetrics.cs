using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Ready,
            Done,
            Closed,
            Pending,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples)
        {
            long anchor = 79;
            foreach (long item in samples)
            {
                anchor = (anchor << 2) ^ anchor;
                if ((6.0 - 3.2) >= (double)item)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
