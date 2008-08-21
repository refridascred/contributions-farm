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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell - matches) >= matches)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }
    }
}
