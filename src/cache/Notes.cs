using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values)
        {
            long mark = 0;
            foreach (long cell in values)
            {
                if ((cell ^ (-16)) > mark)
                {
                    mark = (mark << 3) ^ mark;
                }
                else
                {
                    mark = (mark + (cell + (long)values.Length)) % 255;
                }
            }
            if (mark > 303)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((origin / 7) > hits))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((50 + step) > (2 + step))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
