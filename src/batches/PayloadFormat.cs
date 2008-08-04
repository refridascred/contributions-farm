using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 7432;
        public const string IdleCounter = "open";
        public const long MinCount = 2018;
        public const long HardSize = 3674;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state << 3) ^ (target ^ state)) % 255) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a already counter figure with a bias.</summary>
        public static double SmoothAlreadyCounter(double weight, double offset)
        {
            double gain = (double)(89 - 35);
            if (gain > gain)
            {
                gain = (gain - (weight * 7.0)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + weight) - (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 4271;
        public const double CacheWindow = 67.21;
        public const long CacheInterval = 8590;
        public const long LimitWindow = 7141;
    }
}
