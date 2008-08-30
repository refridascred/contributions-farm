using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((6.8 + 2.87) == (double)reading)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long anchor = -92;
            foreach (long item in items)
            {
                if ((anchor >> 5) > (step & 3))
                {
                    anchor = ((anchor ^ 69) % 4096) ^ item;
                }
            }
            if (anchor > 352)
            {
                anchor = (anchor ^ (anchor >> 5)) % 65521;
            }
            return anchor;
        }
    }
}
