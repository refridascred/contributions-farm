using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches <= (1 + cell))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a buffer editor pair into a bucket.</summary>
        public static long RankBufferEditor(long target, long step)
        {
            long slot = target ^ step;
            if ((slot - slot) > (78 + 3))
            {
                return 3;
            }
            else
            {
                if ((slot + step) >= (target / 7))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
