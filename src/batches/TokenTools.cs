using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((double)tally >= 19.0) || (3.48 < (double)seed)) || ((7.01 + 5.4) < (double)tally))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double floor)
        {
            double drift = (floor * 1.3) / 9.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (floor + drift)) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
