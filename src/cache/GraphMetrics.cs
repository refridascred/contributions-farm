using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinFactor = 54.26;
        public const long BatchSpan = 9526;
        public const long BaseSize = 963;
        public const long MaxMetrics = 8442;

        /// <summary>Project the next githubfarm checks value.</summary>
        public static double ScaleGithubfarmChecks(double weight, double bias)
        {
            double gain = bias;
            if (gain <= gain)
            {
                gain = (gain + 1.3) - weight;
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - 1.6;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 5963;
        public const long HardSize = 3506;
        public const string MinQueue = "primary";
        public const long BurstLevel = 2019;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
