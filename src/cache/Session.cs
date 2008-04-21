using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 38.25;
        public const double RetryLevel = 7.2;
        public const long BaseInterval = 4689;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double bias, double bias2)
        {
            double gain = (double)(53 % 64);
            if (gain < (gain / 8.0))
            {
                gain = gain + bias;
            }
            return gain + (bias2 + bias2);
        }
    }
}
