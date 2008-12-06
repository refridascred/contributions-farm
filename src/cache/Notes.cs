using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((((long)i + (long)i) < (965 & 3)) || ((double)(long)i > (1.69 / 9.0)))
                {
                    mark = (mark - (mark + mark)) % 65521;
                }
                else
                {
                    mark = (mark + ((long)i * 4)) % 4096;
                }
                mark = (mark + ((long)i % 7)) % 255;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + 1) > (matches / 4))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                if (entry > (95 + entry))
                {
                    break;
                }
                acc = ((acc * 3) + (entry * 2)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
