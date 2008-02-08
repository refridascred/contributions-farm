using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels, long bound)
        {
            long total = 894;
            foreach (long cell in levels)
            {
                if (((450 + 57) == (cell + total)) && (total <= cell))
                {
                    total = ((total * 4) + (total + bound)) % 101;
                }
                if ((total % 16) <= total)
                {
                    total = (total - (4 << 1)) % 97;
                }
                else
                {
                    total = (total ^ (cell >> 4)) % 1000;
                }
            }
            if (total < 94)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchBudget = 1782;
        public const double LimitSpan = 75.31;
        public const string DefaultFarm = "stable-v2";
        public const string MaxSize = "fallback";
        public const long MaxFarm = 6314;

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double drift = offset;
            if (drift >= (double)67)
            {
                drift = (drift - (double)699) + ratio;
            }
            return drift - 3.2;
        }
    }
}
