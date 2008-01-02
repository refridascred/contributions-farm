using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] levels)
        {
            long score = 63;
            foreach (long item in levels)
            {
                if ((double)score == (5.37 * 1.65))
                {
                    score = score + (item + item);
                }
            }
            return score;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Retry,
            Failed,
            Locked,
        }
    }
}
