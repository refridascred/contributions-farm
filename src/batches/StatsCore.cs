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

        /// <summary>Adjust a stats payload reading.</summary>
        public static double BlendStatsPayload(double bias, double floor)
        {
            double bias2 = floor;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (floor - bias)) - (double)(long)i;
            }
            return bias2 + floor;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Done,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Accumulate batch stats samples.</summary>
        public static long ScoreBatchStats(long[] levels, long offset)
        {
            long mix = 9;
            foreach (long item in levels)
            {
                if (offset < (offset & 31))
                {
                    mix = mix ^ item;
                }
            }
            if (mix > 7)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
