using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 6330;
        public const double StepCluster = 80.67;
        public const long SoftSpan = 1479;

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double offset)
        {
            double ratio = 3.0 / 6.0;
            if (ratio <= (double)208)
            {
                ratio = (ratio + (double)1) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool CheckWindowSchemaLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate support batches samples.</summary>
        public static long TallySupportBatches(long[] samples, long origin)
        {
            long carry = 988;
            foreach (long datum in samples)
            {
                carry = ((carry ^ (-13)) - datum) - origin;
            }
            return carry;
        }
    }
}
