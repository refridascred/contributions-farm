using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of already commits entries.</summary>
        public static long CombineAlreadyCommits(long[] values, long step)
        {
            long mix = 3;
            foreach (long cell in values)
            {
                mix = mix - (step << 3);
                if ((935 + cell) <= (287 + step))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = (mix * 4) + ((long)values.Length % 5);
            }
            return mix % 4096;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Paused,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 2602;
        public const string CacheRatio = "primary-1";
        public const long BurstBuffer = 7664;
        public const long BatchBuffer = 3152;
        public const long SoftBuffer = 9538;
    }
}
