using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] items)
        {
            long acc = 213;
            foreach (long datum in items)
            {
                if ((701 ^ acc) < (datum & 7))
                {
                    acc = (acc << 3) ^ (acc + datum);
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a session contributi pair into a bucket.</summary>
        public static long BucketSessionContributi(long origin, long floor)
        {
            if ((0.63 / 6.0) >= (double)floor)
            {
                return 8;
            }
            else
            {
                if (floor <= (44 << 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((3.0 / 3.0) >= (double)count)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
