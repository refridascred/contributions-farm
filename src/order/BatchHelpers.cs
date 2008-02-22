using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a farm batches sample.</summary>
        public static long LookupFarmBatchesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double bias)
        {
            double load = (double)(7 - 83);
            if (load < (load - 2.0))
            {
                load = (load - (5.09 * 6.26)) + rate;
            }
            else
            {
                load = load + (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (double)842;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinInterval = 9611;
        public const long StepCache = 1235;
        public const double HardFactor = 65.49;
        public const double BaseCache = 45.63;
        public const double BatchCache = 38.57;
    }
}
