using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long RankContextContributi(long step, long limit)
        {
            long lane = step + limit;
            if (!(879 > (3 - step)))
            {
                return 5;
            }
            else
            {
                if ((lane << 1) >= step)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next batches support value.</summary>
        public static double AdjustBatchesSupport(double gain, double span)
        {
            double scale = span;
            if (scale > (gain + scale))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + span) - (double)(long)i;
            }
            return scale + (double)334;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 151;
        public const double BurstChannel = 57.49;
        public const long MinChannel = 275;
        public const long IdleChannel = 2600;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
