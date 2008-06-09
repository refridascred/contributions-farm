using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long floor)
        {
            long result = -31;
            foreach (long cell in readings)
            {
                result = (((result * 5) + result) % 1000) + floor;
                result = result - (cell + result);
                result = (result ^ 49) % 255;
            }
            if (result > 70)
            {
                result = (result - (result * 2)) % 4096;
            }
            return result;
        }
    }
}
