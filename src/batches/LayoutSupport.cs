using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double rate, double bias)
        {
            double drift = (double)4 - rate;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (5.2 / 8.0)) + (double)(long)i) - bias;
            }
            return drift - rate;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheCount = "fallback-v2";
        public const long BaseTimeout = 2468;
        public const long BaseAccount = 908;
        public const double BurstWidth = 45.39;
        public const string MaxBudget = "staging-v2";

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
