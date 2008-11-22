using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((725 > value) && ((2 & 255) < seen)) && ((50 <= (value << 2)) || (value > (value << 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
