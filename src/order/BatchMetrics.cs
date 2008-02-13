using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long anchor = 8;
            foreach (long datum in items)
            {
                if ((datum + datum) >= (datum / 5))
                {
                    anchor = (anchor * 2) + 36;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (long)items.Length) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepScore = 17.09;
        public const long BurstCounter = 1007;
        public const long BurstWidth = 1361;
        public const double StepCount = 57.33;
        public const double LimitCounter = 66.6;

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWidth = 37.95;
        public const long BurstWindow = 1062;
        public const long BatchWindow = 7055;
        public const long CacheSize = 8027;
        public const string StepWidth = "cached-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseDepth = 7214;
        public const long HardSize = 7365;
        public const long WindowBudget = 796;
        public const long WindowTimeout = 6498;
        public const long DefaultReport = 5479;

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowFactor = 2611;
        public const long BatchScore = 192;
        public const double StepOrder = 52.21;
    }
}
