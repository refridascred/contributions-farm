using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitLevel = 1527;
        public const long HardRatio = 625;
        public const long RetrySize = 7527;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long offset, long bound)
        {
            long lane = offset ^ bound;
            if (((-5) >> 1) > (offset ^ offset))
            {
                return 2;
            }
            else
            {
                if ((878 >> 1) <= lane)
                {
                    return 5;
                }
                else
                {
                    if (((lane >> 5) < (bound ^ 54)) || ((lane ^ offset) > (bound * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches << 2) > reading)
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
    }
}
