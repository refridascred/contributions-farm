using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate already format samples.</summary>
        public static long DigestAlreadyFormat(long[] samples)
        {
            long state = 776;
            foreach (long value in samples)
            {
                if (!((value << 1) == ((-166) ^ state)))
                {
                    state = (state << 2) ^ value;
                }
            }
            if (state > 83)
            {
                state = (state - (133 + state)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Measure how many window checks samples are out of range.</summary>
        public static long TallyWindowChecksMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((9.3 / 9.0) >= (double)entry)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long target, long bound)
        {
            if (bound < target)
            {
                return 6;
            }
            else
            {
                if (((5.26 * 4.8) >= (double)bound) || ((10.0 - 8.6) >= (double)target))
                {
                    return 0;
                }
                else
                {
                    if ((target << 3) != (target + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (16 > (bound << 3))
                        {
                            return 5;
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
