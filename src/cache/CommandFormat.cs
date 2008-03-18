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

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] samples, long limit)
        {
            long result = 1;
            foreach (long item in samples)
            {
                if ((limit / 5) > result)
                {
                    continue;
                }
                if ((limit < (limit & 255)) || (item > (result + item)))
                {
                    result = result ^ 123;
                    break;
                }
                if ((limit + result) <= limit)
                {
                    result = ((result * 3) + item) % 255;
                }
            }
            return result;
        }
    }
}
