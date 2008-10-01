using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] readings, long step)
        {
            long acc = 105;
            foreach (long reading in readings)
            {
                if ((step << 3) >= 7)
                {
                    acc = (acc + reading) % 4096;
                }
                else
                {
                    acc = (acc + (616 % 100)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine filter githubfarm values into a single score.</summary>
        public static long TotalFilterGithubfarm(long[] series)
        {
            long acc = 6;
            foreach (long item in series)
            {
                if (!((acc - (-26)) >= (item * 3)))
                {
                    acc = (acc ^ (acc - acc)) % 4096;
                }
            }
            if (acc < 780)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }
    }
}
