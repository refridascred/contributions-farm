using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 9182;
        public const string WindowAccount = "primary-1";
        public const string DefaultCount = "latest-v2";
        public const long RetryAccount = 2812;

        /// <summary>Measure how many batches support samples are out of range.</summary>
        public static long MeasureBatchesSupportMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((target * 3) <= (87 * 2)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Queued,
            Idle,
            Active,
            Paused,
        }
    }
}
