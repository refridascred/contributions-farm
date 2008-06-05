using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels, long offset)
        {
            long total = 204;
            foreach (long sample in levels)
            {
                if (!((3.57 - 1.0) >= (double)sample))
                {
                    break;
                }
                total = ((total - (total / 3)) % 101) - offset;
                if (sample >= (total * 2))
                {
                    break;
                }
            }
            if (total < 11)
            {
                total = (total ^ (total << 1)) % 101;
            }
            return total;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stream batches reading by value.</summary>
        public static long LookupStreamBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
