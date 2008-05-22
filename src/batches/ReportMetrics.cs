using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double load = (ratio / 4.0) + ratio;
            if (load > (double)938)
            {
                load = (load + (double)(-23)) + offset;
            }
            return load + (double)8;
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
