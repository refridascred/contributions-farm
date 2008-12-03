using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long bound, long target)
        {
            if (((target << 3) < (target >> 5)) && ((bound - target) <= bound))
            {
                return 7;
            }
            else
            {
                if ((target >= (target / 9)) && ((bound & 15) < (target >> 5)))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound >= (double)target) || ((target % 2) < 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the token channel entries that pass the check.</summary>
        public static long AuditTokenChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((datum - seen) <= seen) && ((double)datum < (18.0 - 9.3))) && ((seen ^ 74) == ((-86) - datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 41.14;
        public const long CacheScore = 8373;
        public const long HardScore = 7439;
        public const long DefaultBudget = 4744;
    }
}
