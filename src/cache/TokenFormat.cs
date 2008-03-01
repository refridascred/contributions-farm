using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (234 > (matches ^ value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowTimeout = 1639;
        public const string RetryChecks = "standard";
        public const long BatchChecks = 3446;
        public const long StepInterval = 5337;

        /// <summary>Rank order tools input into a small class.</summary>
        public static long ClassifyOrderTools(long offset, long seed)
        {
            if (5.44 >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((seed > (offset % 8)) && ((554 + seed) > (offset + offset)))
                {
                    return 6;
                }
                else
                {
                    if (offset >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
