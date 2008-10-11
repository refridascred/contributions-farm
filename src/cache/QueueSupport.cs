using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a profile session figure with a bias.</summary>
        public static double AdjustProfileSession(double weight, double span)
        {
            double weight2 = 9.0;
            if (weight2 < weight2)
            {
                weight2 = weight2 - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + weight2) - (double)(long)i;
            }
            return weight2 + span;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long seed)
        {
            if ((14 - origin) < (seed + seed))
            {
                return 3;
            }
            else
            {
                if ((992 & 31) >= origin)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < (ratio + scale))
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio + (ratio / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio + (double)258;
        }
    }
}
