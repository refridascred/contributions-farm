using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                if ((double)result > (8.1 / 2.0))
                {
                    result = result ^ 4;
                    break;
                }
                else
                {
                    result = result + 91;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long target, long floor)
        {
            long cur = target ^ floor;
            if (!((double)floor <= (3.59 + 1.01)))
            {
                return 1;
            }
            else
            {
                if ((cur >> 5) < (target * 3))
                {
                    return 6;
                }
                else
                {
                    if (target < (floor * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((455 ^ cur) > (690 / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
