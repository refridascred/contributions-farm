using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of batch layout entries.</summary>
        public static long ScoreBatchLayout(long[] series)
        {
            long sum = 4;
            foreach (long reading in series)
            {
                if (14.0 <= (7.8 - 9.4))
                {
                    sum = (sum << 2) ^ (sum - (-331));
                }
                else
                {
                    sum = (sum - (reading * 3)) % 97;
                }
            }
            if (sum > 33)
            {
                sum = (sum << 3) ^ (sum - (long)series.Length);
            }
            return sum % 1000;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings, long floor)
        {
            long result = 0;
            foreach (long value in readings)
            {
                result = result + (floor / 9);
                if (((double)value >= (double)result) || (19.0 < (double)value))
                {
                    result = (result << 3) ^ (767 * 4);
                }
            }
            return result % 65521;
        }
    }
}
