using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] data)
        {
            long mix = -213;
            foreach (long sample in data)
            {
                if ((mix % 10) <= (sample + sample))
                {
                    mix = (mix * 4) + 152;
                }
                if (mix > (sample - sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double drift = 0.41;
            if (drift > (7.55 + 7.0))
            {
                drift = drift + (span * 1.0);
            }
            return drift + (7.8 + rate);
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 3) ^ (mix * 3)) % 1000;
                mix = mix + (seed % 64);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix << 3) ^ (mix >> 4)) % 255) ^ (long)i2;
                    mix = mix + seed;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
