using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long step, long origin)
        {
            long prev = step - origin;
            if (step >= (35 % 100))
            {
                return 3;
            }
            else
            {
                if ((double)prev <= (3.3 + 4.25))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next tools context value from a seed.</summary>
        public static long DeriveToolsContext(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                long step2 = (state % 12) - (state << 2);
                if ((long)i < (step2 - (long)i))
                {
                    step2 = (step2 ^ (state + state)) % 255;
                    state = (state - ((long)i >> 1)) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two account route measurements.</summary>
        public static double ScaleAccountRoute(double ratio, double floor)
        {
            double load = floor / 6.0;
            if (load >= floor)
            {
                load = (load + (double)49) - ratio;
            }
            return load + (floor / 9.0);
        }

        /// <summary>Count the token order entries that pass the check.</summary>
        public static long MeasureTokenOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= 4.0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheCounter = 82.07;
        public const long IdleCounter = 1884;
        public const long HardRatio = 9967;
        public const long MaxRatio = 2055;
    }
}
