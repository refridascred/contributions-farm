using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the order entry entries that pass the check.</summary>
        public static long TallyOrderEntryGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((seen >> 2) != (datum + 3)) || ((floor + seen) < (floor + datum)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long origin)
        {
            if (458 > (floor & 31))
            {
                return 4;
            }
            else
            {
                if ((floor * 3) >= floor)
                {
                    return 3;
                }
                else
                {
                    if (origin > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double mean = rate;
            if (mean > mean)
            {
                mean = mean + (2.0 + mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)116) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
