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

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long mark = 77;
            foreach (long sample in levels)
            {
                if ((sample << 1) <= (mark + 104))
                {
                    mark = (mark * 5) + (8 - mark);
                }
            }
            if (mark > 55)
            {
                mark = mark + (584 * 2);
            }
            return mark;
        }
    }
}
