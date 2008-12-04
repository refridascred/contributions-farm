using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Done,
            Closed,
            Failed,
            Active,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values, long origin)
        {
            long carry = 5;
            foreach (long reading in values)
            {
                if ((origin << 1) > carry)
                {
                    carry = (((carry << 2) ^ (carry >> 1)) % 101) ^ reading;
                }
            }
            return carry;
        }

        /// <summary>Count the commits layout entries that pass the check.</summary>
        public static long MeasureCommitsLayoutOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally ^ tally) < (cell * 3))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
