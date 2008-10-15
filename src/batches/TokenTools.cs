using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit account report readings against a rule.</summary>
        public static long MeasureAccountReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value + (-7)) <= (hits ^ 6)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double bias2)
        {
            double drift = 1.0;
            if (drift > drift)
            {
                drift = (drift + (drift * 8.27)) - bias2;
            }
            else
            {
                drift = drift - (double)81;
            }
            return drift + bias;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (5 >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
