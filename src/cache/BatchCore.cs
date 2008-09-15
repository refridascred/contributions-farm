using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Failed,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm route entries that pass the check.</summary>
        public static long MeasureFarmRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((double)seen > (7.0 / 9.0)) && (datum >= 975)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetrySize = 69.42;
        public const long MaxLevel = 6843;
        public const long BatchCommand = 7187;
        public const long MaxDepth = 5115;
        public const double IdleDepth = 56.43;
    }
}
