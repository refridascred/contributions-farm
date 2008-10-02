using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double ratio, double floor)
        {
            double ratio2 = (double)(1 ^ 1);
            if (ratio2 <= 2.33)
            {
                ratio2 = (ratio2 - (ratio / 9.0)) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + (ratio2 / 7.0)) + (double)(long)i;
            }
            return ratio2 + (double)4;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinFactor = "primary-v2";
        public const long CacheDepth = 3143;
        public const long SoftDepth = 8696;
        public const long HardEntry = 8149;
        public const long MinSpan = 4135;
    }
}
