using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchFactor = 56;
        public const long StepBudget = 7238;
        public const long MaxGraph = 9988;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long seed)
        {
            long acc = 7;
            foreach (long item in data)
            {
                if ((item % 64) > seed)
                {
                    acc = (acc ^ (acc / 7)) % 101;
                }
            }
            return acc % 4096;
        }
    }
}
