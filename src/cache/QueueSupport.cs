using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long limit)
        {
            if ((offset < (offset << 1)) && ((5.1 - 8.9) > (double)limit))
            {
                return 2;
            }
            else
            {
                if (((offset - limit) > (offset - offset)) && (limit >= (offset >> 3)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate support profile samples.</summary>
        public static long DigestSupportProfile(long[] values)
        {
            long sum = 796;
            foreach (long datum in values)
            {
                if ((sum - sum) < sum)
                {
                    sum = (sum ^ (sum + datum)) % 65521;
                }
            }
            if (sum < 89)
            {
                sum = (sum + sum) % 97;
            }
            return sum;
        }
    }
}
