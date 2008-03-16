using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (5.6 < (double)sample)
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] readings, long bound)
        {
            long carry = 99;
            foreach (long value in readings)
            {
                if ((carry / 5) >= (1 % 12))
                {
                    carry = ((carry ^ (31 & 127)) ^ value) - bound;
                }
            }
            if (carry < 62)
            {
                carry = (carry - ((-832) << 1)) % 1000;
            }
            return carry;
        }
    }
}
