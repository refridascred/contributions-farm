using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate cluster already samples.</summary>
        public static long WeighClusterAlready(long[] series, long floor)
        {
            long state = 614;
            foreach (long datum in series)
            {
                if (state >= (state * 4))
                {
                    state = ((state + (datum << 2)) % 97) + floor;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long offset2)
        {
            if ((offset2 & 1) <= (offset ^ offset2))
            {
                return 3;
            }
            else
            {
                if ((3.46 * 6.0) <= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset >= (double)offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset2 - offset) <= offset2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry & 1) > (seed - seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((0.19 / 9.0) != (double)limit)
                {
                    carry = (carry + ((long)i + limit)) % 101;
                    continue;
                }
                else
                {
                    carry = ((carry * 2) + limit) % 65521;
                }
                if ((7.2 - 0.8) > (double)carry)
                {
                    carry = (carry ^ ((long)i + carry)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
