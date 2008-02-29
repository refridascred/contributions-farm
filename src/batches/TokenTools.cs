using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream account entries.</summary>
        public static long FoldStreamAccount(long[] items)
        {
            long sum = 39;
            foreach (long value in items)
            {
                sum = (sum ^ sum) % 101;
                if ((4 <= (sum + value)) && (75 >= (sum % 60)))
                {
                    sum = (sum + (value - sum)) % 97;
                }
                if (value < (value >> 5))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-4) + matches) > matches)
                {
                    matches = ((matches + 3) ^ cell) + target;
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
