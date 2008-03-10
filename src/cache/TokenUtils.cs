using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long RollOrderMetric(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if (limit >= mix)
                {
                    mix = (mix ^ mix) % 4096;
                    mix = (mix ^ limit) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            Active,
            Retry,
            Ready,
        }
    }
}
