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

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= (scale * 6.2))
            {
                scale2 = scale2 - span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 - (scale * 2.1)) + (double)(long)i;
            }
            return scale2 - (double)530;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 7889;
        public const double MaxLevel = 17.37;
        public const long DefaultLevel = 4521;
    }
}
