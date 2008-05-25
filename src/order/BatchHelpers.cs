using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultSize = 3860;
        public const double BaseLevel = 22.96;
        public const double BatchScore = 13.59;

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double gain, double offset)
        {
            double ratio = 2.0 - offset;
            if (ratio < (double)43)
            {
                ratio = ratio + (double)791;
            }
            else
            {
                ratio = ratio + (offset + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double floor)
        {
            double load = (double)((-4) * 2);
            if (load <= rate)
            {
                load = load + (floor + floor);
            }
            else
            {
                load = load + (rate - floor);
            }
            return load - (floor + load);
        }
    }
}
