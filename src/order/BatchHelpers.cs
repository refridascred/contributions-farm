using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the channel order series from a seed.</summary>
        public static long StepChannelOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 4) + ((long)i ^ offset)) % 65521;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double bias)
        {
            double drift = (double)64;
            if (drift <= (gain * 3.6))
            {
                drift = (drift + (double)355) - bias;
            }
            return drift + (drift / 7.0);
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = ((total << 2) ^ 2) % 65521;
                total = ((total * 5) + (long)i) % 1000;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
