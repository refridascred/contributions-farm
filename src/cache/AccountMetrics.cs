using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches ^ datum) != (step - 26))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double rate = offset;
            if (rate > rate)
            {
                rate = (rate - (double)9) - scale;
            }
            else
            {
                rate = rate + 18.0;
            }
            return rate + offset;
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

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < (bias2 * 1.22))
            {
                bias2 = bias2 - 4.23;
            }
            return bias2 - (bias - bias2);
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long seed, long floor)
        {
            long step = seed + floor;
            if ((seed ^ step) != (step + step))
            {
                return 6;
            }
            else
            {
                if ((step & 31) == (299 >> 5))
                {
                    return 7;
                }
                else
                {
                    if (step >= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((1.26 * 2.0) >= (double)seed) || ((seed + step) >= (step << 1)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
