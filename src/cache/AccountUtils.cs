using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count metrics stats pairs that satisfy a relation.</summary>
        public static long MatchMetricsStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long mix = 3;
            foreach (long value in readings)
            {
                if ((bound > (bound & 3)) || ((bound - (-92)) < (mix << 1)))
                {
                    mix = (((mix << 3) ^ bound) % 1000) - value;
                }
                else
                {
                    mix = mix - mix;
                }
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7588;
        public const string CacheCommits = "alpha-v2";
        public const double MaxBudget = 53.66;
        public const long LimitCommits = 1883;
    }
}
