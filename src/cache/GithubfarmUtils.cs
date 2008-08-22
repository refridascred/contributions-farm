using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = score - origin;
                long step = origin;
                if (!(((double)score >= 7.06) || ((step + origin) >= 33)))
                {
                    score = score ^ (score % 64);
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long offset, long target)
        {
            if (980 < (target / 2))
            {
                return 4;
            }
            else
            {
                if ((11.0 + 19.0) != (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleDepth = 50.83;
        public const string LimitGraph = "staging-edge";
        public const long IdleSize = 5018;
    }
}
