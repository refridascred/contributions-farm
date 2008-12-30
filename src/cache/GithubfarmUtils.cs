using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double scale, double floor)
        {
            double drift = scale / 5.0;
            if (drift <= scale)
            {
                drift = drift + (4.59 + floor);
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double bias, double offset)
        {
            double load = (bias - 8.6) + (offset * 2.63);
            if (load > 3.13)
            {
                load = load - (load - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
