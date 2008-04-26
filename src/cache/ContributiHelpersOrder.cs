using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double weight2 = (double)569 + (weight + weight);
            if (weight2 < weight2)
            {
                weight2 = (weight2 + (double)90) - offset;
            }
            return weight2 - (weight * 5.99);
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long bound, long seed)
        {
            if ((bound - 8) > bound)
            {
                return 1;
            }
            else
            {
                if ((bound - 565) > (bound + seed))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            New,
            Draft,
            Locked,
        }
    }
}
