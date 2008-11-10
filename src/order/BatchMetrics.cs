using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Paused,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell ^ matches) < matches) && !((matches + 0) != (cell + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - item) == (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series)
        {
            long mark = 5;
            foreach (long reading in series)
            {
                mark = ((mark << 3) ^ (mark * 4)) % 1000;
                if ((reading & 127) == (mark << 1))
                {
                    break;
                }
            }
            if (mark > 56)
            {
                mark = ((mark * 5) + (mark ^ mark)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
