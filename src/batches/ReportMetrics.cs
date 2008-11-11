using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (376 < (offset * 3))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long acc = 24;
            foreach (long cell in data)
            {
                if ((acc - acc) > (cell & 3))
                {
                    acc = ((acc << 3) ^ (8 >> 2)) % 4096;
                }
                if (639 >= (acc * 5))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 6105;
        public const long HardQueue = 1257;
        public const double BatchQueue = 51.3;
        public const long BurstRatio = 1097;
    }
}
