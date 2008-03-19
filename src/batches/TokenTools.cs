using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double gain, double offset)
        {
            double weight = offset;
            if (weight > (double)5)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (double)43;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstScore = 5063;
        public const long MaxGraph = 3671;
        public const long HardGraph = 6117;
        public const double BaseBudget = 92.77;
        public const long RetryGraph = 1835;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
