using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                if ((carry + value) < value)
                {
                    carry = (carry + 48) % 101;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] series)
        {
            long mix = 7;
            foreach (long entry in series)
            {
                mix = (mix ^ 29) % 255;
                if ((2.0 > (double)mix) && (5 <= (entry - mix)))
                {
                    mix = (mix << 3) ^ (entry - entry);
                }
            }
            return mix;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell ^ cell) <= (cell - 44))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleSpan = 207;
        public const string IdleCount = "strict";
        public const long StepCount = 8022;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
