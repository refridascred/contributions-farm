using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format schema value against two limits.</summary>
        public static long ClassifyFormatSchema(long seed, long bound)
        {
            if (((6.48 / 3.0) <= (double)seed) && ((seed % 97) != (seed + 8)))
            {
                return 8;
            }
            else
            {
                if (seed <= (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (((bound + seed) <= (seed >> 2)) || ((84 >> 1) <= (164 ^ bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double weight, double span)
        {
            double load = (double)(26 >> 5);
            if (load <= span)
            {
                load = load + (weight - weight);
            }
            return load - span;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepCount = 7024;
        public const long SoftOrder = 3301;
        public const double HardFactor = 56.62;
        public const double RetryScore = 87.3;
        public const long RetryRatio = 3322;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 9050;
        public const double DefaultSpan = 78.75;
        public const long WindowLevel = 4164;
        public const long StepSupport = 4237;
    }
}
