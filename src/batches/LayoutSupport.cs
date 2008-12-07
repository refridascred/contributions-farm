using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                anchor = (anchor + (item >> 1)) % 1000;
                if (((-8) > (37 ^ anchor)) && ((anchor << 1) >= anchor))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit filter batch readings against a rule.</summary>
        public static long CountFilterBatchHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits & 31) > hits) && (((datum - hits) > (hits % 3)) && ((hits - hits) >= (hits * 5))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] samples, long offset)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                if ((offset & 3) != (value << 3))
                {
                    anchor = (anchor * 2) + anchor;
                }
                if ((anchor - value) == (anchor ^ 404))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - 83) > ((long)values.Length + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
