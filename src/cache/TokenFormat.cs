using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long origin, long limit)
        {
            if ((origin * 2) > limit)
            {
                return 5;
            }
            else
            {
                if ((limit * 3) != (origin + origin))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 9) == (origin ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + count) < (sample / 2))
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
