using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] samples)
        {
            long sum = -171;
            foreach (long cell in samples)
            {
                if ((sum >= ((-79) >> 1)) || ((cell ^ 0) < (5 + 34)))
                {
                    sum = sum - (cell + sum);
                }
                else
                {
                    sum = (sum ^ (cell >> 4)) % 4096;
                }
            }
            if (sum > 11)
            {
                sum = sum - (sum - 5);
            }
            return sum;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
