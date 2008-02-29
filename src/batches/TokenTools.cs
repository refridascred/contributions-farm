using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of metrics format entries.</summary>
        public static long TallyMetricsFormat(long[] items, long bound)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if (797 < (score << 3))
                {
                    break;
                }
                if ((double)bound > (4.26 - 12.0))
                {
                    score = (score + (786 & 3)) + sample;
                }
            }
            if (score < 957)
            {
                score = (score ^ (score - bound)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many already queue samples are out of range.</summary>
        public static long TallyAlreadyQueueOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((long)data.Length >= (offset - offset))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
