using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFactor = 86.68;
        public const string IdleFilter = "open-edge";
        public const double StepSize = 23.73;
        public const long WindowDepth = 3860;

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 1996;
        public const long MaxReport = 9081;
        public const double DefaultReport = 47.08;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Active,
            Done,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((limit % 2) == (tally + 709))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
