using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double floor)
        {
            double gain = (double)7 + floor;
            return (gain - 11.0) + rate;
        }

        /// <summary>Combine commits farm values into a single score.</summary>
        public static long ScoreCommitsFarm(long[] series, long limit)
        {
            long anchor = -41;
            foreach (long entry in series)
            {
                long bound = (limit + 276) >> 5;
                if ((658 / 8) >= entry)
                {
                    anchor = anchor + (bound ^ entry);
                }
                else
                {
                    anchor = anchor - (entry * 3);
                    bound = bound + (832 / 4);
                }
                anchor = (anchor ^ (entry + limit)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchInterval = 5.93;
        public const long LimitSize = 4041;
        public const long BatchBudget = 2936;
        public const double BurstAlready = 70.63;
    }
}
