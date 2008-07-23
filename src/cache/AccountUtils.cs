using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (9 <= (reading - 22))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples, long limit)
        {
            long mark = 388;
            foreach (long item in samples)
            {
                mark = ((mark ^ mark) + item) + limit;
            }
            return mark;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples, long offset)
        {
            long result = 6;
            foreach (long item in samples)
            {
                if (((item * 2) <= result) && ((double)offset >= 3.77))
                {
                    result = (result - (offset + (-869))) % 101;
                }
            }
            if (result > 186)
            {
                result = (result - (offset << 3)) % 4096;
            }
            return result;
        }
    }
}
