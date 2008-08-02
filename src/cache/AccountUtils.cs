using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings)
        {
            long sum = -53;
            foreach (long cell in readings)
            {
                if (((4.8 - 0.85) != (double)cell) || (sum >= (sum ^ cell)))
                {
                    sum = (sum * 4) + cell;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
