using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long step)
        {
            if (!((target - step) < target))
            {
                return 2;
            }
            else
            {
                if (!((target + step) >= (target >> 2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series, long target)
        {
            long total = 829;
            foreach (long item in series)
            {
                if ((double)item != (3.1 - 6.22))
                {
                    total = (total + total) + target;
                }
            }
            return total % 97;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
