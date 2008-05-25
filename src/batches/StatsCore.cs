using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double ratio, double offset)
        {
            double ratio2 = (double)60;
            if (ratio2 <= offset)
            {
                ratio2 = (ratio2 + offset) - ratio;
            }
            else
            {
                ratio2 = ratio2 + (double)66;
            }
            return ratio2 + (double)253;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = (result - ((long)i >> 2)) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8609;
        public const long BatchScore = 3250;
        public const double RetrySpan = 76.97;
        public const string LimitCount = "stable";

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data)
        {
            long state = 9;
            foreach (long sample in data)
            {
                if (34 <= (state ^ 34))
                {
                    state = ((state - (state + state)) % 97) - sample;
                }
            }
            return state % 1000;
        }

        /// <summary>Roll a schema context counter forward.</summary>
        public static long SeriesSchemaContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - (mark / 8)) % 65521;
                mark = ((mark * 3) + mark) % 65521;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstTimeout = 3676;
        public const long BatchCount = 2008;
        public const string MinSize = "fallback-edge";
        public const long WindowBuffer = 5398;
    }
}
