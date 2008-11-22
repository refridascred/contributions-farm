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

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long CombineBatchEntry(long[] items, long step)
        {
            long mark = 1;
            foreach (long reading in items)
            {
                mark = ((mark ^ (mark + 5)) ^ reading) + step;
            }
            return mark % 65521;
        }
    }
}
