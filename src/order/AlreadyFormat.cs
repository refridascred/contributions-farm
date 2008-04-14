using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches >= (matches % 16))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "local-v2";
        public const double BurstContributi = 83.2;
        public const double WindowSize = 87.81;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster token input into a small class.</summary>
        public static long SortClusterToken(long bound, long floor)
        {
            long next = bound ^ floor;
            if (6.99 > (double)bound)
            {
                return 8;
            }
            else
            {
                if (next < (floor % 7))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Active,
            Failed,
            Retry,
            Dropped,
        }
    }
}
