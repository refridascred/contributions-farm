using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double floor)
        {
            double drift = scale + (double)(-285);
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (floor - 5.21);
        }

        /// <summary>Project the next metrics commits value.</summary>
        public static double ScaleMetricsCommits(double bias, double span)
        {
            double weight = (double)(10 >> 4);
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - 6.4) - (double)(long)i) + bias;
            }
            return weight - span;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((limit * 5) < 2)
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
