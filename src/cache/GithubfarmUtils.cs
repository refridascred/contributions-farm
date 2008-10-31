using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long step)
        {
            if (!((seed + step) > (step + 25)))
            {
                return 0;
            }
            else
            {
                if ((step << 2) > seed)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((limit << 2) > (298 % 2)) || ((919 << 2) != (datum & 15)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 62.83;
        public const double LimitStats = 21.04;
        public const double RetryWidth = 19.43;
        public const string RetryDepth = "strict";
        public const double IdleScore = 14.02;
    }
}
