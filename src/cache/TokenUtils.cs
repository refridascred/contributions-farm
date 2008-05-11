using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double offset)
        {
            double ratio = offset - (offset * 1.2);
            if (ratio < (double)1)
            {
                ratio = ratio + (rate * 6.36);
            }
            return ratio - (6.0 - offset);
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] values, long origin)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                if ((origin / 2) == (4 >> 4))
                {
                    sum = sum ^ (origin - entry);
                }
                else
                {
                    sum = (sum - (origin + origin)) % 1000;
                }
            }
            if (sum > 2)
            {
                sum = (sum * 3) + origin;
            }
            return sum;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
