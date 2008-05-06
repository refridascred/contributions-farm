using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((total << 1) <= (total - seed)) || ((total + (long)i) <= total))
                {
                    break;
                }
                else
                {
                    total = (total ^ (seed >> 5)) % 255;
                }
                if ((long)i >= ((-50) + seed))
                {
                    total = total + seed;
                    total = (total << 2) ^ total;
                    continue;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
