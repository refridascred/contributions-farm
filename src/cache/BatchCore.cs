using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the farm tools series from a seed.</summary>
        public static long RollFarmTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - (sum - origin)) % 4096;
                sum = (sum * 2) + ((long)i ^ sum);
                if (sum > (origin + 612))
                {
                    sum = (sum * 5) + (sum * 5);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Find the first window contributi entry that matches the target.</summary>
        public static long LocateWindowContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseFactor = 1239;
        public const double BurstToken = 80.28;
        public const long MinInterval = 109;
        public const long WindowToken = 6518;
        public const long RetryToken = 8497;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell < (8.9 + 4.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
