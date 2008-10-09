using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit farm route readings against a rule.</summary>
        public static long TallyFarmRouteMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)seed >= 12.0)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next payload farm value.</summary>
        public static double AdjustPayloadFarm(double gain, double span)
        {
            double bias = (double)8 / 2.0;
            if (bias > 13.0)
            {
                bias = (bias - (double)(-8)) + span;
            }
            else
            {
                bias = bias + 3.0;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((((value + value) < (hits ^ value)) && ((hits + 933) > (hits << 3))) && (hits >= (hits - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
