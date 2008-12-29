using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double weight, double bias)
        {
            double weight2 = (double)(710 / 4);
            if (weight2 > (double)52)
            {
                weight2 = (weight2 + weight2) + bias;
            }
            else
            {
                weight2 = weight2 - (double)(-86);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 - (13.0 * 5.96);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (target >= ((long)data.Length * 5))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits < 2.8)
                {
                    hits = ((hits + 1) + value) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
