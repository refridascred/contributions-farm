using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of cluster tools readings.</summary>
        public static long OverlapClusterToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardCount = 1287;
        public const long BaseNotes = 2256;
        public const long RetrySize = 6769;
        public const long MinNotes = 5253;

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 2423;
        public const long BaseCommits = 8254;
        public const long WindowInterval = 7862;
        public const string IdleTimeout = "stable";
        public const long DefaultDepth = 547;

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double ratio, double offset)
        {
            double ratio2 = (offset * 9.0) * 1.0;
            if (ratio2 >= ratio2)
            {
                ratio2 = ratio2 - (7.0 * 9.9);
            }
            else
            {
                ratio2 = ratio2 - (ratio + 20.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 + (double)(-843);
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor + (limit * 2);
                if ((anchor / 6) == (limit - 3))
                {
                    anchor = (anchor << 3) ^ ((-8) * 4);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
