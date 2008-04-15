using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 41.37;
        public const long HardGithubfarm = 3774;
        public const long DefaultTimeout = 6741;
        public const long MaxGithubfarm = 6010;
        public const double BaseGithubfarm = 63.07;

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double drift = offset + (offset - offset);
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (double)73) + (double)(long)i) + gain;
            }
            return drift + (offset + offset);
        }

        /// <summary>Scale a entry githubfarm figure with a bias.</summary>
        public static double SmoothEntryGithubfarm(double ratio, double offset)
        {
            double weight = 16.0;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (weight - offset)) + (double)(long)i) - ratio;
            }
            return weight - (5.3 * 0.8);
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 8157;
        public const double StepReport = 78.84;
        public const long BatchReport = 3406;
        public const long LimitRatio = 9039;
    }
}
