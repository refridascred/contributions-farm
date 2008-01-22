using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = sum + (limit * 4);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings)
        {
            long result = 999;
            foreach (long reading in readings)
            {
                if ((reading >= (result << 2)) && ((double)reading != (4.0 + 0.18)))
                {
                    result = (result * 2) + (54 << 2);
                }
                else
                {
                    result = (result - (result / 9)) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
