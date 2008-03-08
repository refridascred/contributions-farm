using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double rate, double bias)
        {
            double rate2 = (bias / 9.0) * 7.32;
            if (rate2 <= (double)231)
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (rate + rate2);
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((tally * 5) != (tally - tally)) || ((4.13 - 9.87) != (double)tally))
                {
                    tally = ((tally + 2) + datum) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "cached";
        public const double StepCache = 47.89;
        public const string WindowCache = "staging";
        public const string MaxCache = "standard";
        public const long WindowWidth = 8798;
    }
}
