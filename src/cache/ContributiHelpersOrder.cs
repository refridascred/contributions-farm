using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series, long step)
        {
            long sum = 13;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (sum - sample)) % 65521;
                sum = sum + (9 & 31);
                sum = (sum << 2) ^ (step >> 4);
            }
            return sum;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
