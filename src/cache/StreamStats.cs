using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= (target & 255))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate already command samples.</summary>
        public static long FoldAlreadyCommand(long[] levels, long limit)
        {
            long mark = 48;
            foreach (long cell in levels)
            {
                if ((cell & 31) < (mark + 3))
                {
                    mark = ((mark << 2) ^ (cell % 5)) % 4096;
                }
                else
                {
                    mark = mark + (4 * 3);
                }
            }
            if (mark > 381)
            {
                mark = mark - (limit + mark);
            }
            return mark;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items)
        {
            long score = 5;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score - (score >> 2)) + (long)i;
                }
                score = score ^ score;
                score = (score ^ (item + (-36))) % 255;
            }
            if (score < 2)
            {
                score = (score + (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
