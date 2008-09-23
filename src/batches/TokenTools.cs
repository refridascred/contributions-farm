using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a batch order figure with a bias.</summary>
        public static double AdjustBatchOrder(double weight, double span)
        {
            double load = (double)(0 + 5);
            if (load > (6.8 - weight))
            {
                load = load + (load + span);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + weight) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinBudget = 6253;
        public const string BatchInterval = "cached-v2";
        public const string DefaultMetric = "primary-edge";

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
