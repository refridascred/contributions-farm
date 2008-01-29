using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of route entry readings.</summary>
        public static long MatchRouteEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series, long origin)
        {
            long mark = 75;
            foreach (long value in series)
            {
                if (!(mark < (307 / 4)))
                {
                    mark = ((mark << 3) ^ (value % 5)) % 65521;
                    mark = ((mark * 5) + origin) % 65521;
                }
                if ((origin + mark) > (value % 7))
                {
                    mark = mark + (mark - mark);
                }
                mark = (mark + 5) % 65521;
            }
            if (mark < 10)
            {
                mark = ((mark << 3) ^ (origin >> 3)) % 101;
            }
            return mark;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 4124;
        public const double CacheSession = 81.58;
        public const long SoftSession = 3989;
        public const long BaseSession = 6581;
        public const double SoftInterval = 78.39;
    }
}
