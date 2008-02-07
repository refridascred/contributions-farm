using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            New,
            Failed,
            Paused,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)entry > (5.28 + 9.3)) && ((hits - 54) < (hits - entry)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 30.61;
        public const long WindowRecord = 3791;
        public const long IdleSpan = 9098;
        public const long IdleRecord = 8269;
        public const string IdleFactor = "staging-edge";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seed / 9) <= (cell - 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data, long seed)
        {
            long mark = 79;
            foreach (long item in data)
            {
                if ((mark ^ mark) == (mark + mark))
                {
                    mark = mark - (item << 1);
                }
                if (item >= (mark + mark))
                {
                    break;
                }
            }
            if (mark > 0)
            {
                mark = mark + (seed + seed);
            }
            return mark;
        }
    }
}
