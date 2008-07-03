using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((3.25 / 2.0) < (double)seed)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
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
