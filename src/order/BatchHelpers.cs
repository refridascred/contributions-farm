using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((matches + cell) <= (matches * 4)) && ((matches ^ matches) <= (matches + cell))) || !((4 + cell) <= cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile counter value against two limits.</summary>
        public static long BucketProfileCounter(long seed, long limit)
        {
            if ((limit + seed) >= limit)
            {
                return 8;
            }
            else
            {
                if ((seed & 127) == (limit + seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed > (1.17 - 6.3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (2.8 <= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitCommits = "local";
        public const double BatchInterval = 23.38;
        public const long IdleScore = 2703;
    }
}
