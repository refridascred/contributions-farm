using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long floor, long limit)
        {
            long bound = floor - limit;
            if (3.0 <= (0.3 + 2.0))
            {
                return 5;
            }
            else
            {
                if ((limit + bound) >= floor)
                {
                    return 8;
                }
                else
                {
                    if ((185 * 4) == (bound + 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)limit <= (4.9 - 0.82)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine record queue values into a single score.</summary>
        public static long TallyRecordQueue(long[] levels)
        {
            long carry = 45;
            foreach (long item in levels)
            {
                if (((item / 6) != (item / 7)) || ((item + item) > carry))
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 255;
                }
            }
            if (carry > (-291))
            {
                carry = carry ^ (carry & 1);
            }
            return carry % 4096;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Pending,
            Closed,
            Synced,
            New,
        }
    }
}
