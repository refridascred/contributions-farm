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

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6340;
        public const long CacheWidth = 8723;
        public const long StepBudget = 9251;
        public const long BatchEntry = 2837;
        public const string BurstEntry = "cached";

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
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
