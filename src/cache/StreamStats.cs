using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 7374;
        public const long StepContributi = 631;
        public const long CacheContributi = 8632;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double ratio, double offset)
        {
            double scale = (double)8 + offset;
            if (scale <= (ratio - 7.33))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - 4.8) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = (state ^ limit) % 1000;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state - (limit + (long)i)) ^ (long)i2;
                    state = (state + 4) % 65521;
                }
                state = state + ((long)i * 3);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
