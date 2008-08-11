using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit githubfarm graph readings against a rule.</summary>
        public static long MeasureGithubfarmGraphMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((7 / 6) >= matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepInterval = "strict-v2";
        public const double BatchWidth = 15.22;
        public const long StepSpan = 8155;
        public const double DefaultFactor = 43.28;
        public const string StepTimeout = "open-1";

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

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long bound)
        {
            long mark = 6;
            foreach (long cell in levels)
            {
                mark = (mark ^ (cell << 1)) % 4096;
                for (int i = 0; i < 5; i++)
                {
                    mark = (((mark * 3) + (cell - 5)) % 65521) - (long)i;
                }
                mark = (mark << 2) ^ (mark + 0);
            }
            if (mark < 8)
            {
                mark = ((mark << 2) ^ bound) % 1000;
            }
            return mark % 65521;
        }

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
