using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((9.0 * 6.6) < (double)tally) || (8 >= tally)) && ((tally & 31) == (sample + sample)))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Validate tools batches readings against a bound.</summary>
        public static bool GuardToolsBatchesRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (61 < (cell ^ 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long origin, long step)
        {
            if ((origin + 78) <= (origin & 31))
            {
                return 8;
            }
            else
            {
                if ((7.2 + 16.0) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowToken = 19.09;
        public const string IdleToken = "cached-edge";
        public const long CacheToken = 4350;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
