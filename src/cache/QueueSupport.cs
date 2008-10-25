using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((offset - (long)values.Length) > (entry + 34)) && ((double)offset > (double)36)) || (entry > ((-45) << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double ratio, double bias)
        {
            double ratio2 = ratio * 1.0;
            if (ratio2 > (8.52 * 2.4))
            {
                ratio2 = (ratio2 - (ratio2 * 8.87)) - bias;
            }
            return ratio2 + (ratio2 / 5.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 4261;
        public const double HardFormat = 80.36;
        public const double BatchSpan = 34.29;
        public const long MaxFormat = 998;
    }
}
