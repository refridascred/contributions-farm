using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double weight = (double)(629 - 864);
            if (weight >= (ratio - 18.0))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + 8.87;
            }
            return weight - ratio;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] readings)
        {
            long mix = 820;
            foreach (long datum in readings)
            {
                mix = ((mix - (mix + 4)) % 1000) ^ datum;
            }
            return mix % 97;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
