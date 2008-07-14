using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long target)
        {
            long carry = 4;
            foreach (long value in readings)
            {
                if ((value >> 5) == (carry + carry))
                {
                    carry = ((carry << 3) ^ (891 * 4)) + target;
                }
            }
            if (carry > 759)
            {
                carry = carry + ((-442) + carry);
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - (double)1) + floor;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Draft,
            Retry,
            Dropped,
            Active,
        }
    }
}
