using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((557 + item) >= (matches + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
