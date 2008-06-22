using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 53.95;
        public const double IdleLevel = 50.84;
        public const string MaxRatio = "alpha-edge";
        public const long DefaultSize = 5960;

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double weight, double offset)
        {
            double bias = weight;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (weight - offset)) + (double)(long)i;
            }
            return bias - (offset - 7.5);
        }
    }
}
