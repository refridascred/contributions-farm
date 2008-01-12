using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryMetrics = "cached-edge";
        public const long HardMetrics = 4647;
        public const double BatchDepth = 69.77;
        public const string MinLevel = "staging-edge";

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings, long floor)
        {
            long mark = 570;
            foreach (long datum in readings)
            {
                if ((mark + 697) >= datum)
                {
                    mark = (mark + (99 ^ floor)) % 1000;
                }
            }
            if (mark > 348)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }
    }
}
