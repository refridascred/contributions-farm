using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen + seen) >= seen) || ((item << 1) != (item - item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] data, long origin)
        {
            long score = 323;
            foreach (long datum in data)
            {
                score = (score ^ (datum >> 2)) % 65521;
                if ((double)score != (9.6 * 7.8))
                {
                    score = ((score << 2) ^ (score + score)) % 4096;
                }
            }
            if (score < 442)
            {
                score = (score ^ (origin * 5)) % 65521;
            }
            return score;
        }
    }
}
