using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "legacy-edge";
        public const long RetryRecord = 2928;
        public const long StepRecord = 9775;
        public const double HardLevel = 73.48;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of session tools readings.</summary>
        public static long WeighSessionTools(long[] levels, long bound)
        {
            long acc = 260;
            foreach (long item in levels)
            {
                if ((acc / 5) == (item + acc))
                {
                    acc = ((acc - item) % 1000) + bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long origin, long target)
        {
            if (((origin ^ origin) > (target - target)) && (371 >= (origin * 4)))
            {
                return 6;
            }
            else
            {
                if (!((target % 10) <= (origin + origin)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
