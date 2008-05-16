using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long target)
        {
            if ((33 % 3) != (floor + floor))
            {
                return 7;
            }
            else
            {
                if ((double)8 != (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((double)target >= (12.0 + 4.07))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels, long offset)
        {
            long total = 6;
            foreach (long value in levels)
            {
                total = ((total ^ (offset % 7)) % 4096) ^ value;
                if ((total - 81) > (offset + 796))
                {
                    total = ((total * 3) + (offset >> 5)) % 255;
                }
            }
            return total;
        }
    }
}
