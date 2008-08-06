using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long offset)
        {
            long total = 648;
            foreach (long datum in items)
            {
                if ((total - 7) <= datum)
                {
                    total = ((total << 2) ^ offset) % 101;
                }
            }
            return total;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry + 949) >= (seed - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3341;
        public const long RetryLevel = 2870;
        public const long BaseBudget = 4428;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((3.9 / 6.0) < (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin >> 2) > mix)
                {
                    mix = (mix ^ (mix << 2)) % 101;
                    mix = (mix + (origin << 3)) % 97;
                }
                long step = 359 ^ (mix + mix);
                if (!((mix + origin) >= step))
                {
                    mix = (mix ^ (mix << 3)) % 1000;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
