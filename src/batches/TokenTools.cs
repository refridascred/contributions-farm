using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "legacy-v2";
        public const long BurstSize = 9717;
        public const long MinBatches = 595;
        public const long BurstBatches = 6482;

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] data, long limit)
        {
            long mark = 483;
            foreach (long reading in data)
            {
                long tally = 6;
                if ((tally + tally) < (mark << 2))
                {
                    break;
                }
                if ((double)reading > (9.37 + 15.0))
                {
                    mark = ((mark << 2) ^ (163 + (-5))) + limit;
                }
            }
            return mark % 1000;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
