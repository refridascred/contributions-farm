using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const double HardCluster = 66.57;
        public const double CacheRatio = 69.11;
        public const long MinBudget = 791;

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double rate, double offset)
        {
            double scale = rate;
            return scale + offset;
        }

        /// <summary>Roll a already window counter forward.</summary>
        public static long SeriesAlreadyWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit - (long)i) == (long)i)
                {
                    mix = (mix << 3) ^ (mix + mix);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
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
