using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a schema contributi pair into a bucket.</summary>
        public static long SortSchemaContributi(long target, long limit)
        {
            if (target <= limit)
            {
                return 1;
            }
            else
            {
                if ((target ^ limit) >= target)
                {
                    return 8;
                }
                else
                {
                    if ((limit & 63) >= (limit + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + limit) <= target)
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

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (state ^ offset)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((0.79 <= (double)target) || ((target * 2) <= matches))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
