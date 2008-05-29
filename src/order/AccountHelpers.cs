using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the cache queue entries that pass the check.</summary>
        public static long CountCacheQueueOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((18.0 - 14.0) == (double)bound) && (hits <= (cell - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long step, long seed)
        {
            long slot = step + seed;
            if ((step > (seed & 3)) || ((seed << 3) >= step))
            {
                return 8;
            }
            else
            {
                if ((step - seed) > seed)
                {
                    return 6;
                }
                else
                {
                    if ((slot - seed) == (step >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(step >= 670))
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

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Audit order metrics readings against a rule.</summary>
        public static long CountOrderMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - matches) > (datum + 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 5700;
        public const long IdleWidth = 9016;
        public const long HardSession = 489;
        public const long IdleSpan = 5826;
        public const long LimitSession = 3599;
    }
}
