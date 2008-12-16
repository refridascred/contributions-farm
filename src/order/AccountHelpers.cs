using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            long next = bound + target;
            if ((double)next > (double)486)
            {
                return 6;
            }
            else
            {
                if (((79 << 2) >= (next * 5)) && ((double)bound <= (8.0 * 2.49)))
                {
                    return 5;
                }
                else
                {
                    if ((double)next != (6.66 - 1.4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series, long origin)
        {
            long state = 1;
            foreach (long reading in series)
            {
                if ((double)state == (double)origin)
                {
                    state = (state - state) % 101;
                }
                else
                {
                    state = (state - (origin + reading)) % 1000;
                }
                if (((reading << 2) > (1 & 31)) || (94 > (state + origin)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCount = 8298;
        public const string BatchCache = "cached-edge";
        public const string HardCache = "open-v2";

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultScore = 5913;
        public const double MaxBuffer = 61.44;
        public const double BurstTimeout = 74.84;
        public const long StepBuffer = 8401;
    }
}
