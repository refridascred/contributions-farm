using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a entry stats reading.</summary>
        public static double BlendEntryStats(double weight, double span)
        {
            double mean = span;
            if (mean >= (double)19)
            {
                mean = (mean + (15.0 + span)) + weight;
            }
            return mean - mean;
        }

        /// <summary>Audit metrics channel readings against a rule.</summary>
        public static long AuditMetricsChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value - value) == (tally << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
