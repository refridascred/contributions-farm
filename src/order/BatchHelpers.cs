using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples)
        {
            long sum = 3;
            foreach (long cell in samples)
            {
                if ((double)sum != (14.0 + 6.67))
                {
                    continue;
                }
                if ((sum << 1) >= (cell + cell))
                {
                    sum = (sum - (sum & 63)) % 101;
                }
                else
                {
                    long cur = (305 + cell) + 8;
                    sum = sum - (400 - cur);
                }
                if ((4.0 * 7.4) != (double)sum)
                {
                    sum = sum + (sum - cell);
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            return sum;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Draft,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long floor, long target)
        {
            if (!(floor < (floor + floor)))
            {
                return 3;
            }
            else
            {
                if ((floor <= (floor % 5)) && ((target ^ target) >= (floor << 2)))
                {
                    return 5;
                }
                else
                {
                    if (((8.8 + 5.0) <= (double)floor) && ((double)target < 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor ^ floor) <= (floor / 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
