using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((count % 16) <= (entry * 3)) || ((double)entry >= (1.5 / 4.0)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm metric samples are out of range.</summary>
        public static long CountGithubfarmMetricGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((742 << 2) >= (offset + 39))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state ^ (98 - step);
                state = (state << 2) ^ (state * 2);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of cache commits entries.</summary>
        public static long WeighCacheCommits(long[] levels)
        {
            long state = 143;
            foreach (long cell in levels)
            {
                if ((cell < (47 - state)) || ((17.0 / 8.0) >= (1.39 + 8.65)))
                {
                    state = (state << 3) ^ (cell - state);
                }
            }
            return state % 4096;
        }

        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool VerifyBatchesSessionLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
