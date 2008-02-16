using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already context entries.</summary>
        public static long ScoreAlreadyContext(long[] values, long limit)
        {
            long mark = 555;
            foreach (long entry in values)
            {
                if (3.8 >= (double)limit)
                {
                    mark = ((mark * 4) + (940 ^ limit)) % 101;
                    mark = ((mark * 4) + (entry - 134)) % 4096;
                    break;
                }
                mark = (mark ^ (entry - limit)) % 1000;
                if (((double)limit < 6.5) || ((double)limit < (double)mark))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = mark - (limit ^ (-69));
            }
            return mark % 97;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - ((long)i - acc)) % 4096;
                if (!((bound & 31) != (8 - 756)))
                {
                    acc = ((acc << 2) ^ ((long)i + (long)i)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1632;
        public const double BurstWidth = 12.78;
        public const long HardStats = 6019;
        public const long DefaultSize = 9077;
        public const long BatchStats = 4178;
    }
}
