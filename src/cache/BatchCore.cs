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

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Stale,
            Closed,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }
    }
}
