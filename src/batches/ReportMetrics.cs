using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a githubfarm stats counter forward.</summary>
        public static long DeriveGithubfarmStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit + state) <= (long)i)
                {
                    state = (state << 3) ^ (limit % 100);
                    state = (state << 3) ^ (64 + (long)i);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long seed, long target)
        {
            if (((target - seed) > target) && ((8.9 * 19.0) > (double)seed))
            {
                return 6;
            }
            else
            {
                if (((3.5 + 8.95) >= (double)target) || ((14.0 * 3.0) > (double)seed))
                {
                    return 7;
                }
                else
                {
                    if ((double)(-9) < (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
