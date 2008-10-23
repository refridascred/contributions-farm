using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Pending,
            Active,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 136;
        public const double CacheRatio = 4.32;
        public const long BatchBudget = 6517;
        public const long BurstSpan = 547;
        public const long MaxScore = 1695;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long seed, long target)
        {
            if ((seed ^ target) > (target + target))
            {
                return 7;
            }
            else
            {
                if ((391 + seed) < (7 & 7))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed <= 16.0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long anchor = 60;
            foreach (long entry in samples)
            {
                if ((anchor + entry) > entry)
                {
                    anchor = (anchor + (79 & 127)) % 255;
                }
            }
            return anchor;
        }
    }
}
