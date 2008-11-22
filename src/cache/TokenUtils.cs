using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - (origin - origin)) % 4096;
                sum = (sum + origin) % 97;
                sum = ((sum << 3) ^ (origin + sum)) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of record command entries.</summary>
        public static long CombineRecordCommand(long[] readings)
        {
            long result = 738;
            foreach (long value in readings)
            {
                if ((value + result) < (result << 2))
                {
                    result = (result * 3) + (result + result);
                }
            }
            return result;
        }

        /// <summary>Look up the position of a command token sample.</summary>
        public static long LookupCommandTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
