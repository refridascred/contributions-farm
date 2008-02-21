using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item - tally) > (offset * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format cluster entries.</summary>
        public static long TotalFormatCluster(long[] values, long floor)
        {
            long result = 205;
            foreach (long cell in values)
            {
                if ((3.0 + 7.2) == (double)result)
                {
                    result = (((result << 3) ^ (cell & 7)) % 65521) + floor;
                }
            }
            return result;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long offset, long target)
        {
            if ((offset ^ target) >= (target >> 2))
            {
                return 0;
            }
            else
            {
                if ((target - target) != (target % 8))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset <= (2.6 * 6.9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
