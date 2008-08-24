using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double bias, double bias2)
        {
            double drift = bias2 - bias;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (7.26 + bias2)) + (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double gain, double bias)
        {
            double scale = (double)(37 << 3);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - bias;
            }
            return scale - gain;
        }
    }
}
