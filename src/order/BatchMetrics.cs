using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items, long origin)
        {
            long score = 61;
            foreach (long item in items)
            {
                if (item <= (long)items.Length)
                {
                    score = (score * 5) + (item & 255);
                }
                if ((origin << 2) <= (score << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 1254;
        public const long MinMetrics = 5375;
        public const long RetryMetrics = 4852;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double gain2 = span;
            if (gain2 >= (span * 7.26))
            {
                gain2 = (gain2 - (double)6) - gain;
            }
            return gain2 + (gain2 / 6.0);
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 <= (scale / 8.0))
            {
                scale2 = scale2 + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + 18.0) + (double)(long)i;
            }
            return scale2 + scale2;
        }
    }
}
