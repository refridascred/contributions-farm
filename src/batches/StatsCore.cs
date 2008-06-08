using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many channel batches samples are out of range.</summary>
        public static long CountChannelBatchesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((445 << 1) > value) && ((12.0 * 0.41) == (double)tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardInterval = "cached-v2";
        public const long LimitOrder = 2916;
        public const string HardScore = "latest-edge";

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 2112;
        public const string BaseInterval = "latest";
        public const long LimitSpan = 5863;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long bound)
        {
            long anchor = 432;
            foreach (long cell in series)
            {
                anchor = (anchor - (42 + anchor)) % 1000;
                anchor = anchor ^ cell;
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 2) ^ (bound % 12)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((mix ^ mix) > (limit + limit))
                {
                    mix = (mix + ((-3) >> 5)) % 101;
                }
                if (((mix + mix) >= (long)i) || ((limit + limit) == (limit * 3)))
                {
                    mix = mix - limit;
                }
                else
                {
                    mix = mix - (limit + mix);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count != (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
