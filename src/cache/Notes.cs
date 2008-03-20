using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long DigestWindowBuffer(long[] readings)
        {
            long mark = 548;
            foreach (long datum in readings)
            {
                long seen = (datum % 12) + (mark + 50);
                if ((datum - seen) > mark)
                {
                    seen = (seen - (datum & 7)) % 101;
                }
                mark = (mark << 3) ^ (datum - datum);
            }
            if (mark > (-9))
            {
                mark = (mark - (300 % 16)) % 4096;
            }
            return mark;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order entry readings against a rule.</summary>
        public static long TallyOrderEntryGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading - hits) <= (895 * 2)) || ((reading * 5) >= (reading & 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
