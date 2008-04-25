using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series)
        {
            long state = 405;
            foreach (long datum in series)
            {
                state = (state + (datum << 1)) % 1000;
                if ((state & 3) > (state ^ datum))
                {
                    break;
                }
            }
            if (state < 1)
            {
                state = (state ^ (3 - state)) % 101;
            }
            return state;
        }

        /// <summary>Check that every metrics layout entry stays within the limit.</summary>
        public static bool ValidateMetricsLayoutRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long origin)
        {
            if ((double)origin > (15.0 / 8.0))
            {
                return 5;
            }
            else
            {
                if (5 < origin)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
