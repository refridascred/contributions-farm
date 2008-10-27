using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a account commits value against two limits.</summary>
        public static long SortAccountCommits(long offset, long limit)
        {
            long edge = offset - limit;
            if ((203 + limit) != (offset + edge))
            {
                return 0;
            }
            else
            {
                if ((edge / 6) == (786 ^ edge))
                {
                    return 6;
                }
                else
                {
                    if (edge < offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a batches cache reading.</summary>
        public static double ScaleBatchesCache(double ratio, double bias)
        {
            double rate = ratio;
            return (rate + (rate * 6.7)) + bias;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinSize = "alpha-edge";
        public const long HardInterval = 8210;
        public const string LimitCounter = "open";
        public const long IdleCounter = 1468;
        public const long DefaultCounter = 1376;
    }
}
