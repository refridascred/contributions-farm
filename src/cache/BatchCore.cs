using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of schema cache readings.</summary>
        public static long CompareSchemaCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Closed,
            Active,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftDepth = 4913;
        public const double StepLevel = 40.91;
        public const double SoftSize = 46.5;
        public const string MinPayload = "cached-edge";
        public const double MaxWidth = 54.62;

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
