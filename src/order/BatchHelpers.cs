using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of already stream entries.</summary>
        public static long FoldAlreadyStream(long[] data)
        {
            long mix = 10;
            foreach (long entry in data)
            {
                if ((2.8 / 6.0) < (double)entry)
                {
                    continue;
                }
                mix = ((mix << 2) ^ (entry + 82)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Grade a window report value against two limits.</summary>
        public static long RankWindowReport(long limit, long bound)
        {
            if ((limit <= (limit + limit)) && ((double)limit == (2.5 * 14.0)))
            {
                return 2;
            }
            else
            {
                if (((7.2 + 2.24) > (double)bound) || (bound >= (limit / 6)))
                {
                    return 7;
                }
                else
                {
                    if ((bound * 5) > (bound % 64))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
