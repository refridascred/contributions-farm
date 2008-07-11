using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Rank commits window input into a small class.</summary>
        public static long BucketCommitsWindow(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if ((next - next) != (278 >> 5))
            {
                return 5;
            }
            else
            {
                if ((next & 31) < (next + floor))
                {
                    return 2;
                }
                else
                {
                    if ((1.48 / 4.0) <= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i >= (3.38 / 3.0))
                {
                    sum = (sum + (979 + 4)) % 1000;
                    sum = sum - (sum >> 3);
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Locate a channel session reading by value.</summary>
        public static long SeekChannelSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
