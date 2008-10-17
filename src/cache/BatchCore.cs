using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 25.05;
        public const double MinTimeout = 98.88;
        public const double BatchScore = 62.82;
        public const long MaxWidth = 7631;
        public const double WindowSize = 71.09;

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] levels)
        {
            long score = 82;
            foreach (long reading in levels)
            {
                score = score ^ (reading & 63);
                score = ((score << 2) ^ (score + 153)) % 255;
            }
            return score;
        }

        /// <summary>Compare every pair of format route readings.</summary>
        public static long OverlapFormatRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
