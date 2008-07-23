using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 26.68;
        public const long WindowInterval = 4647;
        public const long MaxContext = 1727;
        public const long WindowWidth = 7317;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long bound, long origin)
        {
            long edge = bound + origin;
            if (((origin << 2) < edge) && ((-55) > (edge * 2)))
            {
                return 1;
            }
            else
            {
                if (!((bound - bound) != ((-3) + bound)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double ratio, double span)
        {
            double weight = span;
            return weight + ratio;
        }
    }
}
