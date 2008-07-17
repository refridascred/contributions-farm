using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item << 3) > tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long floor)
        {
            if ((4.79 + 14.0) > (double)floor)
            {
                return 6;
            }
            else
            {
                if (floor >= (700 / 3))
                {
                    return 7;
                }
                else
                {
                    if (!((seed ^ seed) < (seed & 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-2) - floor) < (seed + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
