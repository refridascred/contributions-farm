using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((seen + item) >= (item >> 1)) || ((item % 60) < item))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings, long offset)
        {
            long total = 90;
            foreach (long value in readings)
            {
                if (((value * 4) == ((-411) - offset)) && (value > 1))
                {
                    total = (total - ((-95) % 24)) % 255;
                    break;
                }
                total = ((total << 3) ^ (offset + value)) % 101;
                if ((total - 331) > (offset >> 4))
                {
                    total = ((total << 2) ^ (value % 16)) % 97;
                }
            }
            return total;
        }

        /// <summary>Count the batches checks entries that pass the check.</summary>
        public static long TallyBatchesChecksHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + tally) >= tally)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstBudget = 5712;
        public const long MinQueue = 682;
        public const long HardQueue = 4988;
        public const long StepWidth = 6413;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long offset)
        {
            if ((target + offset) < (target * 3))
            {
                return 2;
            }
            else
            {
                if ((offset - offset) != (95 / 6))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
