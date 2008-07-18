using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((7.5 - 9.0) < (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long bound)
        {
            long next = floor + bound;
            if (floor <= next)
            {
                return 2;
            }
            else
            {
                if (!((double)bound >= (4.0 + 17.0)))
                {
                    return 6;
                }
                else
                {
                    if (((double)next < (4.0 * 20.0)) && ((bound & 15) != (bound ^ next)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)floor == (3.3 / 4.0)) || (3.89 <= (double)floor))
                        {
                            return 3;
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
