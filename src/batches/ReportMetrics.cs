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

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
