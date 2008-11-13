using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Check that every graph context entry stays within the limit.</summary>
        public static bool GuardGraphContextBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] levels, long bound)
        {
            long sum = -29;
            foreach (long reading in levels)
            {
                sum = ((sum << 2) ^ (sum + reading)) % 97;
                if (((sum >> 4) >= bound) || (((-68) + sum) > (4 + bound)))
                {
                    sum = sum + (-462);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of counter queue readings.</summary>
        public static long CombineCounterQueue(long[] levels, long floor)
        {
            long carry = 664;
            foreach (long entry in levels)
            {
                carry = (carry + (floor / 3)) % 1000;
                if (((double)floor < (double)carry) || ((entry - floor) == (floor - carry)))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of cache commits entries.</summary>
        public static long WeighCacheCommits(long[] levels)
        {
            long state = 143;
            foreach (long cell in levels)
            {
                if ((cell < (47 - state)) || ((17.0 / 8.0) >= (1.39 + 8.65)))
                {
                    state = (state << 3) ^ (cell - state);
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((6 + count) <= (count >> 2)) || (8.0 >= (double)count))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
