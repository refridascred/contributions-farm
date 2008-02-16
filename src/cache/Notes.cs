using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Failed,
            Active,
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSpan = 3520;
        public const long BurstContributi = 3289;
        public const long DefaultFactor = 8070;
        public const long DefaultContributi = 79;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double drift = (double)(29 - 80);
            if (drift <= (bias + 0.73))
            {
                drift = (drift - 6.9) - weight;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (drift - bias);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 2235;
        public const long SoftSession = 9326;
        public const long SoftSize = 5893;
        public const string WindowWidth = "primary-edge";
    }
}
