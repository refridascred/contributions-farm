using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Stale,
            Active,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Check that every batches account entry stays within the limit.</summary>
        public static bool CheckBatchesAccountRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 7965;
        public const double WindowBatches = 87.69;
        public const long RetryBatches = 9924;
        public const string LimitDepth = "cached-edge";
        public const long BaseBatches = 4300;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
