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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long origin, long step)
        {
            long slot = origin - step;
            if (((origin & 1) > slot) || ((-2) <= (slot << 3)))
            {
                return 1;
            }
            else
            {
                if ((step + 224) == (step + 75))
                {
                    return 6;
                }
                else
                {
                    if ((step << 2) <= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 4261;
        public const double HardFormat = 80.36;
        public const double BatchSpan = 34.29;
        public const long MaxFormat = 998;
    }
}
