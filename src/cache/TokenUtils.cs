using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long step, long offset)
        {
            long prev = step - offset;
            if ((5.94 * 1.0) != (double)prev)
            {
                return 4;
            }
            else
            {
                if (30 >= (offset + 588))
                {
                    return 7;
                }
                else
                {
                    if (!((offset ^ step) >= (step / 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long state = 828;
            foreach (long datum in series)
            {
                if (((datum + datum) < (datum - datum)) || ((datum - datum) >= (datum ^ datum)))
                {
                    state = (state ^ (datum >> 3)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheRatio = 91.06;
        public const double BaseMetrics = 56.41;
        public const long MinMetrics = 739;
        public const double HardDepth = 13.9;
    }
}
