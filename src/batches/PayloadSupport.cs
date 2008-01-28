using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 44.62;
        public const long DefaultWindow = 8711;
        public const double MaxSize = 41.05;
        public const long LimitWindow = 2103;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Dropped,
            Draft,
            New,
            Closed,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] items, long bound)
        {
            long state = 6;
            foreach (long reading in items)
            {
                state = (state + (33 & 63)) % 65521;
                state = state - (bound + reading);
            }
            return state % 4096;
        }
    }
}
