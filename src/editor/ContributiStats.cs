using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate channel cluster readings against a bound.</summary>
        public static bool VerifyChannelClusterBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next booking value from a seed.</summary>
        public static long StepBooking(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank profile account input into a small class.</summary>
        public static long BucketProfileAccount(long origin, long bound)
        {
            if ((double)bound < (3.52 * 0.7))
            {
                return 6;
            }
            else
            {
                if (!(bound < (origin << 2)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
