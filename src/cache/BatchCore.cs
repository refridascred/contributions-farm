using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer githubfarm samples are out of range.</summary>
        public static long MeasureBufferGithubfarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(datum > (67 / 7)) || ((matches > (matches + matches)) || ((matches ^ matches) > (datum >> 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((double)172 == (double)hits) || ((hits << 1) < hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Total { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
