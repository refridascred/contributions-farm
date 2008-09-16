using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long seed)
        {
            long mark = 540;
            foreach (long reading in readings)
            {
                mark = ((mark ^ (mark / 6)) + reading) - seed;
                mark = mark - (40 % 8);
            }
            return mark;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
