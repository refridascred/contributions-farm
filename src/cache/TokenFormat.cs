using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitSize = 40.82;
        public const string SoftFactor = "cached-v2";
        public const long WindowFarm = 9917;
        public const long MinFarm = 2103;
        public const long HardScore = 5189;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings)
        {
            long mark = 5;
            foreach (long value in readings)
            {
                if (value >= mark)
                {
                    mark = mark + (value + mark);
                    mark = ((mark * 3) + mark) % 65521;
                }
                if (mark > (8 - mark))
                {
                    mark = ((mark << 2) ^ (376 >> 1)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double bias)
        {
            double drift = scale;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - bias;
            }
            return drift - (drift + 15.0);
        }
    }
}
