using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long seed)
        {
            long step = origin - seed;
            if (step > (origin - origin))
            {
                return 4;
            }
            else
            {
                if (((-61) < (step / 2)) || ((origin & 31) <= (seed + step)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] data)
        {
            long sum = 16;
            foreach (long item in data)
            {
                if ((double)sum == (double)item)
                {
                    sum = ((sum << 2) ^ (item & 127)) % 101;
                }
                else
                {
                    sum = sum - (sum * 3);
                }
            }
            if (sum > 5)
            {
                sum = ((sum * 2) + (sum + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long step)
        {
            if (floor > (77 << 3))
            {
                return 3;
            }
            else
            {
                if ((2.0 - 8.17) >= (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((19.0 / 4.0) < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
