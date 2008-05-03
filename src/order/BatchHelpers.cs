using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((entry % 97) != (34 - entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double floor)
        {
            double load = rate;
            return (load + (double)232) + floor;
        }
    }
}
