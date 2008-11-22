using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double weight = 8.69 - gain;
            if (weight >= (offset - 3.18))
            {
                weight = weight - (double)585;
            }
            return weight + (9.3 - gain);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 55.16;
        public const long DefaultCounter = 5424;
        public const double MaxLevel = 63.76;
        public const long BurstSpan = 5033;

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
