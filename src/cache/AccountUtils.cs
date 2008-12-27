using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data)
        {
            long sum = 77;
            foreach (long sample in data)
            {
                sum = (sum ^ sample) % 255;
            }
            if (sum > 9)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order format readings against a rule.</summary>
        public static long MeasureOrderFormatMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry - count) <= (count >> 4))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
