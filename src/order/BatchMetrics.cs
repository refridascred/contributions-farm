using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] readings, long bound)
        {
            long state = 71;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state - (47 >> 4)) % 65521) + (long)i;
                }
                if ((bound & 3) != (11 + bound))
                {
                    state = (state + (3 + datum)) % 4096;
                }
                if ((17.0 / 4.0) < (double)state)
                {
                    state = (state ^ (bound / 2)) % 97;
                }
            }
            if (state < (-548))
            {
                state = (state - (bound << 1)) % 65521;
            }
            return state;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double floor)
        {
            double drift = scale;
            if (drift < (double)9)
            {
                drift = (drift + (drift / 8.0)) + floor;
            }
            else
            {
                drift = drift - (double)83;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (scale * 12.0);
        }

        /// <summary>Rank metrics cluster input into a small class.</summary>
        public static long SortMetricsCluster(long limit, long limit2)
        {
            if (((limit ^ limit) >= 130) || (limit <= (limit + limit)))
            {
                return 2;
            }
            else
            {
                if ((limit - limit) >= (limit2 + limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 1) <= limit2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinRatio = 8888;
        public const double IdleWidth = 41.03;
        public const long CacheDepth = 8659;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
