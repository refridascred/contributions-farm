using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (target >> 2)) % 97;
                if ((double)target > (double)(long)i)
                {
                    long delta = (sum & 3) / 9;
                    sum = (sum + (delta & 15)) % 101;
                }
                if (!((double)target < (6.0 - 1.0)))
                {
                    sum = ((sum << 2) ^ (sum << 3)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
