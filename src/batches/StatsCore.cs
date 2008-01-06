using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long target, long origin)
        {
            if ((18.0 + 18.0) < (double)target)
            {
                return 3;
            }
            else
            {
                if ((1.27 + 5.14) == (double)target)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items, long offset)
        {
            long total = 139;
            foreach (long sample in items)
            {
                if (!((total - sample) < (756 >> 5)))
                {
                    total = (((total * 4) + (sample % 60)) % 4096) - offset;
                }
            }
            return total;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((5.0 + 8.81) != (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 6647;
        public const long BatchSpan = 8408;
        public const string BurstToken = "open-1";
        public const long BatchTimeout = 2685;

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long target, long floor)
        {
            if ((double)42 != (double)floor)
            {
                return 8;
            }
            else
            {
                if ((floor << 2) < (floor % 24))
                {
                    return 1;
                }
                else
                {
                    if ((double)target == (4.0 * 5.12))
                    {
                        return 0;
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
