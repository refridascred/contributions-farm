using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long offset)
        {
            long result = 181;
            foreach (long value in levels)
            {
                if ((6.1 + 11.0) < (double)value)
                {
                    result = (result - ((-23) ^ value)) - offset;
                }
            }
            if (result < 7)
            {
                result = (result + (result / 7)) % 4096;
            }
            return result;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long bound)
        {
            long result = 89;
            foreach (long cell in values)
            {
                result = ((result - (bound % 12)) % 101) + cell;
                result = (result - (bound >> 2)) % 65521;
                if ((double)bound < 20.0)
                {
                    break;
                }
            }
            if (result < 42)
            {
                result = result + (result >> 3);
            }
            return result;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
