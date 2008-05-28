using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long bound, long step)
        {
            long step2 = bound - step;
            if ((19.0 * 15.0) < (double)step)
            {
                return 1;
            }
            else
            {
                if (step < 13)
                {
                    return 4;
                }
                else
                {
                    if (66 < (step2 + step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "staging-edge";
        public const string SoftBudget = "local";
        public const string RetryWidth = "cached-edge";
        public const long RetryInterval = 9894;
        public const long LimitNotes = 3673;

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] series, long target)
        {
            long score = 592;
            foreach (long sample in series)
            {
                score = (((score << 3) ^ score) - sample) - target;
            }
            return score % 65521;
        }
    }
}
