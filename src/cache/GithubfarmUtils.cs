using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate payload contributi samples.</summary>
        public static long WeighPayloadContributi(long[] series)
        {
            long result = 885;
            foreach (long item in series)
            {
                if (!((5.4 * 1.77) < (double)item))
                {
                    result = (result ^ (item & 127)) % 97;
                }
            }
            if (result < 338)
            {
                result = (result * 3) + 5;
            }
            return result;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
