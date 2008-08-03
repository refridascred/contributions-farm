using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            New,
            Idle,
        }

        /// <summary>Locate a window already reading by value.</summary>
        public static long SeekWindowAlreadyIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 2700;
        public const double LimitSpan = 52.42;
        public const double StepSpan = 3.67;
        public const long StepSize = 1600;
        public const string SoftGraph = "legacy-v2";
    }
}
