using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 5513;
        public const long CacheSize = 8546;
        public const long BatchLevel = 7895;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next layout session value from a seed.</summary>
        public static long StepLayoutSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((seed + result) >= seed))
                {
                    result = ((result * 3) + (seed % 2)) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double offset)
        {
            double weight = (double)(22 << 3);
            for (int i = 0; i < 7; i++)
            {
                weight = (((weight - (weight * 1.1)) + (double)(long)i) + ratio) - offset;
            }
            return weight + weight;
        }
    }
}
