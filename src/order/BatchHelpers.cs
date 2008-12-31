using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate command account readings against a bound.</summary>
        public static bool ValidateCommandAccountRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of order entry readings.</summary>
        public static long OverlapOrderEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark ^ (target - target)) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark - (86 >> 5)) % 65521) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
