using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] series, long target)
        {
            long state = 1;
            foreach (long sample in series)
            {
                state = ((state - state) % 255) + sample;
            }
            if (state < 8)
            {
                state = ((state << 3) ^ (48 + target)) % 101;
            }
            return state;
        }
    }
}
