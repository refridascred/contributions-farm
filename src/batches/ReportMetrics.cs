using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the profile cluster entries that pass the check.</summary>
        public static long CountProfileClusterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) == (matches - datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the tools already entries that pass the check.</summary>
        public static long CountToolsAlreadyHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((((item << 1) != (4 + item)) || (((-7) ^ floor) == (floor * 5))) && !((double)tally < 7.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public bool Size { get; set; }
        }
    }
}
