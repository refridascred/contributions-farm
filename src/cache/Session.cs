using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double offset)
        {
            double mean = (double)(78 - 88);
            if (mean <= offset)
            {
                mean = (mean - 5.75) - rate;
            }
            return mean + mean;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Audit context counter readings against a rule.</summary>
        public static long AuditContextCounterHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (13.0 >= (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
