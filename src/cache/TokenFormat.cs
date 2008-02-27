using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate filter commits readings against a bound.</summary>
        public static bool ValidateFilterCommitsLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate githubfarm order readings against a bound.</summary>
        public static bool ValidateGithubfarmOrderRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long target, long bound)
        {
            long delta = target + bound;
            if ((bound % 97) <= bound)
            {
                return 0;
            }
            else
            {
                if ((target % 10) <= (bound - delta))
                {
                    return 1;
                }
                else
                {
                    if (target >= (bound + target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.2 - 16.0) == (double)delta)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
