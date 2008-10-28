using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (floor * 3.34)) + (double)(long)i) - rate;
            }
            return gain + (5.0 / 9.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCount = 8303;
        public const long BatchCounter = 8313;
        public const double DefaultDepth = 40.45;
        public const double IdleInterval = 95.85;
        public const long SoftRatio = 1062;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of support buffer entries.</summary>
        public static long WeighSupportBuffer(long[] readings)
        {
            long mix = 5;
            foreach (long reading in readings)
            {
                if ((double)reading != (9.04 - 5.44))
                {
                    mix = ((mix << 3) ^ (mix ^ reading)) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
