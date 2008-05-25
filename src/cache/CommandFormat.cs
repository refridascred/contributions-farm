using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((((-24) ^ mix) != ((long)i + 9)) || (((long)i + bound) <= bound))
                {
                    mix = mix - (mix & 31);
                    mix = (mix * 2) + (mix << 2);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double weight, double floor)
        {
            double weight2 = (double)225 - (weight + weight);
            return weight2 - floor;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double ratio = scale;
            if (ratio > ratio)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - 1.0;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio - (floor - ratio);
        }
    }
}
