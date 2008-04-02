using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series, long limit)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if ((anchor % 97) != (78 / 2))
                {
                    anchor = (anchor ^ (limit ^ item)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((tally >> 3) >= (tally & 15)) && (seed < 98))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
