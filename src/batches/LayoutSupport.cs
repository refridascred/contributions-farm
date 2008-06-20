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

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 5148;
        public const double StepPayload = 23.31;
        public const string BasePayload = "fallback";
        public const long BurstPayload = 94;
        public const long StepInterval = 8867;

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

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 9050;
        public const double DefaultSpan = 78.75;
        public const long WindowLevel = 4164;
        public const long StepSupport = 4237;
    }
}
