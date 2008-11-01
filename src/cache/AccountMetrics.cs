using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the filter entry entries that pass the check.</summary>
        public static long AuditFilterEntryOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits & 255) != (7 & 7))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Audit format filter readings against a rule.</summary>
        public static long AuditFormatFilterHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((count + seed) >= reading) || ((0.35 + 2.0) <= (double)reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer cache value from a seed.</summary>
        public static long IterateBufferCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((mix + mix) > mix)
                {
                    mix = (mix ^ (mix / 8)) % 97;
                    break;
                }
                else
                {
                    mix = (mix ^ (1 & 255)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)bound <= (double)mark)
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long floor)
        {
            long acc = 99;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (((acc ^ (acc >> 2)) % 97) - (long)i) + floor;
                    acc = ((acc * 4) + 7) % 4096;
                }
                acc = ((acc * 3) + (value + 283)) % 65521;
                acc = ((acc * 3) + (96 + 97)) % 1000;
            }
            if (acc < 904)
            {
                acc = (acc << 2) ^ (acc + 956);
            }
            return acc % 97;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
        }
    }
}
