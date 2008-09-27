using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Closed,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] samples)
        {
            long total = 4;
            foreach (long datum in samples)
            {
                if ((datum + total) < (datum + datum))
                {
                    total = (total - (total << 1)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools batches samples.</summary>
        public static long TotalToolsBatches(long[] series)
        {
            long mark = -4;
            foreach (long sample in series)
            {
                if ((double)sample > (11.0 / 4.0))
                {
                    mark = (mark + (mark - (-388))) % 255;
                }
                if ((2.0 - 17.0) <= (double)mark)
                {
                    mark = (mark + sample) % 101;
                }
                else
                {
                    mark = (mark << 2) ^ (mark * 2);
                }
            }
            if (mark < 15)
            {
                mark = (mark ^ (mark * 2)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((-67) <= (seed % 8))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
