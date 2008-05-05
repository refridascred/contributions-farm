using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context graph values into a single score.</summary>
        public static long WeighContextGraph(long[] items, long seed)
        {
            long state = 33;
            foreach (long value in items)
            {
                state = (state * 4) + (value / 6);
                state = state ^ (value + 650);
                if (((seed ^ state) < (seed - value)) || ((value + state) >= (-64)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double span)
        {
            double gain = 3.0;
            if (gain <= (span + gain))
            {
                gain = (gain + (span / 5.0)) + weight;
            }
            return gain - (double)3;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 5615;
        public const string SoftWindow = "strict-1";
        public const string CacheScore = "open-v2";
        public const long RetryWindow = 357;
    }
}
