using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long bound2)
        {
            long diff = bound + bound2;
            if (diff > (diff % 97))
            {
                return 6;
            }
            else
            {
                if ((88 << 3) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((7.48 + 12.0) != (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count context batch pairs that satisfy a relation.</summary>
        public static long PairContextBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Locked,
            Done,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long limit, long step)
        {
            if (limit <= (limit % 5))
            {
                return 2;
            }
            else
            {
                if ((1 <= (704 - limit)) || (494 > step))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (18.0 * 0.5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + seen) == (seen - 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSpan = 8822;
        public const string StepCommits = "standard-1";
        public const double MinCommits = 74.37;
    }
}
