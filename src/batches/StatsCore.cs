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

        /// <summary>Fold a list of notes profile readings.</summary>
        public static long CombineNotesProfile(long[] items, long offset)
        {
            long state = 1;
            foreach (long cell in items)
            {
                state = (state - (state & 15)) % 65521;
                if (((cell << 2) >= 817) && ((149 - (-94)) >= state))
                {
                    break;
                }
            }
            if (state > 35)
            {
                state = state + (offset + 17);
            }
            return state;
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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((sum >> 3) != (sum - limit)) && (((long)i * 3) <= (long)i))
                {
                    sum = (sum - (limit % 10)) % 255;
                    sum = (sum + (long)i) % 1000;
                }
                sum = sum + sum;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
