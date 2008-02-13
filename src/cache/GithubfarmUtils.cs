using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of counter route readings.</summary>
        public static long MatchCounterRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate account farm readings against a bound.</summary>
        public static bool CheckAccountFarmLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long origin)
        {
            long acc = 36;
            foreach (long entry in series)
            {
                acc = ((((acc * 3) + (acc + 663)) % 255) ^ entry) - origin;
            }
            return acc;
        }
    }
}
