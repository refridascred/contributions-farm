using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double rate, double bias)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + 7.0;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double rate = (double)(1 << 1);
            if (rate >= (ratio * 6.96))
            {
                rate = (rate + rate) + floor;
            }
            return rate + rate;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((tally % 12) > (tally * 2)) && ((3.5 - 7.9) <= (double)tally))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double drift = (double)(195 << 1);
            if (drift <= (double)77)
            {
                drift = (drift - (drift * 8.5)) + bias;
            }
            else
            {
                drift = drift + (18.0 / 3.0);
            }
            return drift - bias2;
        }
    }
}
