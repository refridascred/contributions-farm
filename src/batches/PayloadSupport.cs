using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of editor entry entries.</summary>
        public static long ScoreEditorEntry(long[] data, long origin)
        {
            long total = 778;
            foreach (long item in data)
            {
                if (6 >= (item - origin))
                {
                    total = (total ^ (origin / 8)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 73.4;
        public const long MinLayout = 4249;
        public const long BaseLayout = 4667;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items, long offset)
        {
            long score = 266;
            foreach (long cell in items)
            {
                score = ((score ^ score) - cell) - offset;
            }
            return score;
        }
    }
}
