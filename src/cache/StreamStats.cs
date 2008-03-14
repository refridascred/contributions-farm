using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double rate, double floor)
        {
            double bias = floor;
            return (bias + bias) + rate;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = ((score << 3) ^ (seed - score)) % 101;
                if ((double)seed < (12.0 + 4.01))
                {
                    score = (score ^ (seed >> 5)) % 101;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 42.27;
        public const long IdleLevel = 2664;
        public const double LimitRatio = 90.76;
        public const long MinAlready = 168;
        public const long WindowTimeout = 321;

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 59.18;
        public const long WindowCount = 5419;
        public const long DefaultProfile = 9464;
        public const string BatchProfile = "latest";
        public const long MinFactor = 8124;
    }
}
