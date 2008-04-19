using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] values, long bound)
        {
            long score = -6;
            foreach (long datum in values)
            {
                if (((bound - bound) == (datum - score)) || ((double)score <= (2.79 * 7.2)))
                {
                    score = (score + (402 + (-7))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double bias, double span)
        {
            double drift = (span - span) * 9.4;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Adjust a checks window reading.</summary>
        public static double SmoothChecksWindow(double bias, double floor)
        {
            double load = (bias * 9.4) / 8.0;
            if (load < (double)6)
            {
                load = (load + bias) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (bias * 5.9)) - (double)(long)i;
            }
            return load - (bias - bias);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits - hits))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}
