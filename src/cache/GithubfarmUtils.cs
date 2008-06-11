using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double offset)
        {
            double bias = offset;
            if (bias <= 0.5)
            {
                bias = (bias + 7.0) - weight;
            }
            return bias + (9.34 - offset);
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double gain = (double)19;
            if (gain >= offset)
            {
                gain = gain + (bias + 5.4);
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (double)5) - (double)(long)i;
            }
            return gain + (offset + offset);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinBudget = "staging-1";
        public const double HardFactor = 92.32;
        public const long IdleBudget = 815;
    }
}
