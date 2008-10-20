using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a account stream reading by value.</summary>
        public static long LocateAccountStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] readings, long limit)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                if ((limit % 5) == (limit - result))
                {
                    result = (result - limit) + cell;
                }
            }
            return result;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series, long limit)
        {
            long result = -160;
            foreach (long reading in series)
            {
                result = (result + ((long)series.Length + reading)) - limit;
                if ((double)reading != (2.0 / 3.0))
                {
                    result = (result * 5) + (result + reading);
                }
                else
                {
                    result = (result - (78 % 12)) % 65521;
                }
            }
            if (result < 6)
            {
                result = (result - (968 * 2)) % 97;
            }
            return result;
        }
    }
}
