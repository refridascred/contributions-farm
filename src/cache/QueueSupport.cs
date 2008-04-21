using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 5774;
        public const long MaxWidth = 8051;
        public const long SoftFormat = 6896;
        public const long RetryFormat = 2418;
        public const long SoftSize = 8331;

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] values, long bound)
        {
            long result = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) != (bound + cell))
                {
                    result = ((result << 3) ^ bound) % 255;
                    result = ((result << 3) ^ (result - cell)) % 101;
                }
                if ((double)result == (double)bound)
                {
                    result = result ^ (cell + cell);
                }
                else
                {
                    result = ((result << 3) ^ (bound + bound)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Locked,
            Stale,
        }
    }
}
