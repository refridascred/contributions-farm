using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of support metric readings.</summary>
        public static long CombineSupportMetric(long[] readings, long seed)
        {
            long state = 24;
            foreach (long cell in readings)
            {
                if ((cell << 2) <= state)
                {
                    state = ((state * 5) + (9 + 3)) % 101;
                }
                if ((cell - state) != (cell + seed))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values, long target)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                sum = ((((sum * 3) + (8 * 3)) % 255) ^ reading) - target;
            }
            return sum % 97;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
