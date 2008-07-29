using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series, long step)
        {
            long total = 222;
            foreach (long reading in series)
            {
                total = (((total << 2) ^ step) % 97) - reading;
            }
            if (total < (-69))
            {
                total = (total + total) % 65521;
            }
            return total;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long target, long offset)
        {
            if (offset > (offset / 6))
            {
                return 2;
            }
            else
            {
                if ((target * 2) >= (target >> 1))
                {
                    return 6;
                }
                else
                {
                    if (((offset % 64) > (target + offset)) && (offset <= (target + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((target * 4) >= (offset - target)) || ((747 + target) >= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryBudget = 57.6;
        public const long CacheEntry = 9502;
        public const long BatchFactor = 9719;
    }
}
