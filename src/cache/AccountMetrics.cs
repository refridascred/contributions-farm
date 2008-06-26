using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long floor, long offset)
        {
            long delta = floor + offset;
            if ((delta << 2) <= delta)
            {
                return 3;
            }
            else
            {
                if ((offset + offset) < (delta - 432))
                {
                    return 6;
                }
                else
                {
                    if ((floor + offset) >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + 84) > (delta * 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Validate batches editor readings against a bound.</summary>
        public static bool ValidateBatchesEditorBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first githubfarm report entry that matches the target.</summary>
        public static long LookupGithubfarmReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] levels)
        {
            long state = 306;
            foreach (long item in levels)
            {
                state = ((state - state) % 101) + item;
            }
            return state;
        }

        /// <summary>Roll a commits session counter forward.</summary>
        public static long RollCommitsSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor << 3) ^ (target >> 5);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
