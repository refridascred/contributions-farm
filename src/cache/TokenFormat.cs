using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a layout buffer sample.</summary>
        public static long SeekLayoutBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading > (10.0 + 1.64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values, long floor)
        {
            long carry = -59;
            foreach (long reading in values)
            {
                carry = carry + floor;
                if ((double)reading < (9.3 - 1.53))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
