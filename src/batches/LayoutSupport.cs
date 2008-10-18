using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((3.4 - 8.66) == (double)(long)values.Length) || ((sample - seen) == (55 + seen)))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long TallyCounterContributi(long[] series)
        {
            long anchor = 198;
            foreach (long cell in series)
            {
                anchor = (anchor - cell) % 1000;
            }
            if (anchor < 488)
            {
                anchor = anchor + (35 << 2);
            }
            return anchor;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((double)limit <= 3.4))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Audit report schema readings against a rule.</summary>
        public static long TallyReportSchemaMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (13.0 < (double)seen)
                {
                    seen = ((seen + 2) ^ reading) - offset;
                }
            }
            return seen;
        }
    }
}
