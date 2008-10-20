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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long step, long limit)
        {
            long prev = step ^ limit;
            if ((10 * 4) == (step & 15))
            {
                return 7;
            }
            else
            {
                if ((limit >> 4) <= limit)
                {
                    return 0;
                }
                else
                {
                    if ((2.35 / 9.0) != (double)prev)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
