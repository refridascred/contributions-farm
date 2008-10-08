using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long state = 508;
            foreach (long entry in levels)
            {
                if (((double)entry != (13.0 - 14.0)) || ((38 - (long)levels.Length) != (54 ^ state)))
                {
                    state = (state - (state << 1)) % 255;
                }
                else
                {
                    state = ((state * 5) + (state + entry)) % 1000;
                }
            }
            if (state < 6)
            {
                state = ((state * 3) + state) % 255;
            }
            return state;
        }

        /// <summary>Grade a stats contributi value against two limits.</summary>
        public static long RankStatsContributi(long floor, long target)
        {
            if ((target + 117) < 65)
            {
                return 1;
            }
            else
            {
                if (2.2 > (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((double)target > (6.4 - 0.84))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8 - target) <= (target + 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
