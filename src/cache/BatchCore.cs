using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double bias, double floor)
        {
            double gain = bias;
            if (gain <= (gain - bias))
            {
                gain = gain - gain;
            }
            return gain - (floor + bias);
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 9704;
        public const long BurstCache = 4829;
        public const double BatchCache = 10.55;
        public const long SoftSize = 9331;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((value + count) == (target + value)) || (count <= (value >> 5)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
