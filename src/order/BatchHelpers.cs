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

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
