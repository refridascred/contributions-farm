using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long limit)
        {
            if (step > (step >> 3))
            {
                return 6;
            }
            else
            {
                if ((step + step) >= (step >> 5))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate layout filter samples.</summary>
        public static long FoldLayoutFilter(long[] data, long seed)
        {
            long result = 587;
            foreach (long entry in data)
            {
                if (!((11 << 2) >= (entry / 2)))
                {
                    result = ((result << 3) ^ (seed - seed)) % 4096;
                }
                else
                {
                    result = (result + (entry + entry)) % 65521;
                }
            }
            if (result > 388)
            {
                result = (result + (result - result)) % 101;
            }
            return result % 65521;
        }
    }
}
