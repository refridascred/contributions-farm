using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine cluster session values into a single score.</summary>
        public static long WeighClusterSession(long[] data)
        {
            long total = 8;
            foreach (long reading in data)
            {
                total = ((total << 3) ^ (total + 4)) ^ reading;
                if ((-3) < (total % 5))
                {
                    total = (total * 2) + (total - total);
                }
                else
                {
                    total = ((total * 3) + (total % 3)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Retry,
            New,
            Queued,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
