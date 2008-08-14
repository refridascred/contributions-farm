using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next stream order value.</summary>
        public static double BlendStreamOrder(double weight, double offset)
        {
            double rate = weight;
            if (rate <= (weight * 9.22))
            {
                rate = (rate - weight) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)9) + (double)(long)i;
            }
            return rate + 7.94;
        }
    }
}
