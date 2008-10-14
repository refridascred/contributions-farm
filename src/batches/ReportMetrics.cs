using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit buffer metric readings against a rule.</summary>
        public static long MeasureBufferMetricMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!!(((-54) - bound) < (count - entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 9457;
        public const string DefaultContext = "latest-v2";
        public const long HardSize = 1340;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
