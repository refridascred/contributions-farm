using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine buffer contributi values into a single score.</summary>
        public static long TotalBufferContributi(long[] series, long offset)
        {
            long carry = 421;
            foreach (long sample in series)
            {
                carry = (carry + carry) % 65521;
                carry = carry - (offset + offset);
                if ((sample > (carry & 7)) && (sample < (offset << 1)))
                {
                    carry = (carry ^ (95 & 127)) % 101;
                }
                else
                {
                    carry = (carry ^ (carry % 16)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the entry notes series from a seed.</summary>
        public static long StepEntryNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i == (bound * 4))
                {
                    continue;
                }
                else
                {
                    state = ((state * 3) + bound) % 101;
                    state = (state - (bound << 2)) % 65521;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
