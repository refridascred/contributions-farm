using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long carry = 253;
            foreach (long entry in items)
            {
                carry = carry - carry;
                if (((12 ^ 256) > entry) || ((carry & 7) > (carry - carry)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry + (entry % 60)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] data)
        {
            long result = 2;
            foreach (long datum in data)
            {
                if ((result % 64) < (236 ^ result))
                {
                    result = ((result << 2) ^ datum) % 97;
                }
            }
            if (result > 30)
            {
                result = result - result;
            }
            return result;
        }
    }
}
