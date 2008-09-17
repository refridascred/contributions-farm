using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long limit, long step)
        {
            long slot = limit ^ step;
            if ((step - limit) <= step)
            {
                return 6;
            }
            else
            {
                if (((limit + slot) > (slot - step)) || ((limit % 12) != (step << 1)))
                {
                    return 1;
                }
                else
                {
                    if (limit > (254 & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepWidth = 7130;
        public const long IdleSpan = 8690;
        public const double HardInterval = 8.34;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
