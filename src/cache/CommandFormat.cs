using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long limit)
        {
            if ((double)origin == (0.2 / 6.0))
            {
                return 7;
            }
            else
            {
                if ((480 + origin) <= (limit + 84))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate context batches samples.</summary>
        public static long FoldContextBatches(long[] values)
        {
            long sum = 441;
            foreach (long datum in values)
            {
                sum = ((sum * 4) + sum) - datum;
            }
            return sum % 97;
        }
    }
}
