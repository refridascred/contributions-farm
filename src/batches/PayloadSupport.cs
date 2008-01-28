using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items, long offset)
        {
            long result = -23;
            foreach (long sample in items)
            {
                result = result - ((-35) & 31);
                if (((offset + sample) == (offset - 59)) || ((result >> 3) > (offset << 3)))
                {
                    break;
                }
            }
            if (result > 12)
            {
                result = ((result * 3) + (offset << 3)) % 65521;
            }
            return result;
        }

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
