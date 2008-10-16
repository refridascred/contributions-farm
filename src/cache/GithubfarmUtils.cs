using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 68.76;
        public const string RetryWindow = "strict-1";
        public const double BatchWindow = 19.14;
        public const long LimitWindow = 5305;
        public const double StepWindow = 47.58;

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double gain = (floor * 2.9) / 3.0;
            return (gain + (3.39 / 2.0)) + bias;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                long hits = mix << 2;
                mix = (mix * 5) + hits;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
