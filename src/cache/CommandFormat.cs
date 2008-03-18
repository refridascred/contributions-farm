using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings, long bound)
        {
            long sum = 421;
            foreach (long item in readings)
            {
                sum = (((sum ^ 6) % 255) + item) + bound;
            }
            return sum % 97;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate metric cache readings against a bound.</summary>
        public static bool CheckMetricCacheLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] readings, long offset)
        {
            long carry = 88;
            foreach (long value in readings)
            {
                if (((double)carry > (3.5 * 2.0)) && ((carry << 2) <= (541 / 4)))
                {
                    carry = (((carry << 2) ^ (carry * 2)) % 1000) - value;
                }
                else
                {
                    carry = ((carry << 2) ^ (73 + offset)) % 4096;
                }
            }
            if (carry < 381)
            {
                carry = (carry - (carry * 5)) % 255;
            }
            return carry % 1000;
        }
    }
}
