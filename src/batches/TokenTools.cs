using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double scale, double floor)
        {
            double rate = floor;
            if (rate < scale)
            {
                rate = rate + (5.0 - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (scale * 6.7)) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((8.0 - 3.2) <= (double)entry) && ((double)tally <= (double)entry)) || (tally >= (entry + limit)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double rate = floor;
            return (rate - (double)306) + bias;
        }
    }
}
