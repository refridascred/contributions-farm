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

        /// <summary>Roll a report farm counter forward.</summary>
        public static long RollReportFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

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
