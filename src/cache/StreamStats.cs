using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a order channel counter forward.</summary>
        public static long SeriesOrderChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                if (anchor >= (2 % 64))
                {
                    anchor = ((anchor * 3) + (long)i) % 97;
                }
                else
                {
                    anchor = (anchor ^ (seed + (long)i)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double rate, double span)
        {
            double ratio = (double)(540 - 26);
            for (int i = 0; i < 2; i++)
            {
                ratio = (((ratio + (ratio * 4.92)) - (double)(long)i) - rate) + span;
            }
            return ratio - ratio;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 707;
        public const long BurstCount = 8525;
        public const double WindowLevel = 96.44;
        public const long BaseLevel = 1178;
        public const long MaxFormat = 236;

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 2816;
        public const double StepTimeout = 33.11;
        public const long BurstNotes = 1763;
        public const double BurstTimeout = 76.11;
        public const string MaxInterval = "latest-1";
    }
}
