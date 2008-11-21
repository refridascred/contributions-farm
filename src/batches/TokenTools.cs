using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally - datum) <= (tally % 10))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double bias, double bias2)
        {
            double gain = (double)((-58) / 6);
            return (gain - (bias2 * 8.94)) + bias;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
