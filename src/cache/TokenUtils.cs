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

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Retry,
            Failed,
            Queued,
            New,
            Active,
        }
    }
}
