using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double weight, double offset)
        {
            double load = offset;
            if (load < 4.0)
            {
                load = load - load;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)585) - (double)(long)i;
            }
            return load - (weight + offset);
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values, long seed)
        {
            long total = -1;
            foreach (long cell in values)
            {
                if (((4.0 / 5.0) < (double)cell) || ((double)total >= (4.0 * 17.0)))
                {
                    total = (total ^ (seed & 3)) % 1000;
                }
            }
            if (total > 3)
            {
                total = (total ^ (total ^ seed)) % 255;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchScore = 96.65;
        public const long LimitFilter = 4737;
        public const double MaxDepth = 53.28;
    }
}
