using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Synced,
            New,
            Failed,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "local-1";
        public const long BurstQueue = 312;
        public const long WindowScore = 7687;
        public const long LimitSpan = 2340;

        /// <summary>Match up batch metric samples.</summary>
        public static long OverlapBatchMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
