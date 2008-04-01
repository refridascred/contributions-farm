using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstSpan = 8494;
        public const long StepLevel = 4672;
        public const long HardDepth = 2297;
    }
}
