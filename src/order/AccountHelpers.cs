using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ mix) % 255;
                mix = (mix * 5) + mix;
                mix = (mix + (mix + mix)) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((origin >> 3) == (datum - origin))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
