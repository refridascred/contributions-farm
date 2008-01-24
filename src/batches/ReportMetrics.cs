using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Compare every pair of command session readings.</summary>
        public static long MatchCommandSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double ratio, double floor)
        {
            double mean = (ratio - floor) - (ratio * 8.89);
            if (mean >= floor)
            {
                mean = mean - (double)740;
            }
            return mean - (floor / 5.0);
        }
    }
}
