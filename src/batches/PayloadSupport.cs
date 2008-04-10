using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many report cluster samples are out of range.</summary>
        public static long AuditReportClusterMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((2 * 2) >= (count + count))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
