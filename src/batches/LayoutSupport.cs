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

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long seed, long limit)
        {
            long step = seed ^ limit;
            if ((step + 84) >= step)
            {
                return 6;
            }
            else
            {
                if (((step + step) <= step) || ((double)seed <= 20.0))
                {
                    return 1;
                }
                else
                {
                    if ((step * 3) != (step - limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed <= (limit + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
