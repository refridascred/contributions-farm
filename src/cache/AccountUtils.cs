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

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Closed,
            Dropped,
        }
    }
}
