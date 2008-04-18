using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 > 5.7)
            {
                weight2 = (weight2 - (4.7 / 2.0)) + bias;
            }
            return weight2 + weight;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long offset)
        {
            long lane = seed - offset;
            if (10 < (seed + lane))
            {
                return 8;
            }
            else
            {
                if ((offset >= (lane - (-92))) || (lane <= (134 - lane)))
                {
                    return 6;
                }
                else
                {
                    if ((offset <= (lane + 802)) || ((offset << 1) < 9))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)matches > (8.16 - 8.05))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }
    }
}
