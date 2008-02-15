using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items)
        {
            long acc = -89;
            foreach (long sample in items)
            {
                if ((acc >= (sample * 4)) && ((acc * 2) >= acc))
                {
                    acc = (acc + (sample / 8)) % 101;
                    acc = acc - ((-44) + acc);
                }
                if (((4.55 * 1.3) == (double)sample) && ((1.0 + 4.38) != (double)sample))
                {
                    acc = (acc + acc) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a metric editor reading.</summary>
        public static double AdjustMetricEditor(double scale, double bias)
        {
            double ratio = scale - 4.74;
            if (ratio <= (ratio * 8.2))
            {
                ratio = ratio - (double)441;
            }
            else
            {
                ratio = ratio + (double)(-30);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (bias + ratio)) - (double)(long)i;
            }
            return ratio - 5.22;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
