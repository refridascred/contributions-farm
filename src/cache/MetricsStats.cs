using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long offset, long origin)
        {
            if ((offset - 9) >= (origin - offset))
            {
                return 3;
            }
            else
            {
                if ((double)offset < 8.3)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin != (7.9 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                score = score - (score + limit);
                if (!((19.0 * 14.0) != (double)limit))
                {
                    score = (score + 41) % 65521;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
