using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] levels)
        {
            long mark = 1;
            foreach (long item in levels)
            {
                if (((long)levels.Length + item) > (mark / 9))
                {
                    mark = mark ^ (mark + item);
                }
                else
                {
                    mark = ((mark * 4) + (74 + item)) % 255;
                }
                mark = (mark ^ item) % 4096;
                mark = (mark ^ (item << 1)) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (3.0 + 1.14))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultCount = 8209;
        public const long CacheMetric = 1132;
        public const long LimitMetric = 443;
        public const long WindowMetric = 6483;
        public const long BatchMetric = 5995;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long seed)
        {
            long span = origin + seed;
            if ((span & 1) != (seed + span))
            {
                return 8;
            }
            else
            {
                if ((span ^ origin) >= (span / 5))
                {
                    return 1;
                }
                else
                {
                    if ((span + seed) <= (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (span < (88 % 3))
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
    }
}
