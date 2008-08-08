using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double bias)
        {
            double weight2 = 10.0;
            if (weight2 < weight)
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 + (double)567;
            }
            return weight2 + bias;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix + ((long)i - mix)) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 6397;
        public const long CacheChannel = 5447;
        public const long BurstCount = 2471;
    }
}
