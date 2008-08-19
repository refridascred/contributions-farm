using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a notes account value against two limits.</summary>
        public static long ClassifyNotesAccount(long bound, long floor)
        {
            if ((bound + bound) >= ((-458) & 255))
            {
                return 4;
            }
            else
            {
                if ((((-67) * 2) > (floor + floor)) || ((double)floor <= 15.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound < 20.0) || ((bound ^ 79) < bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the metrics route entries that pass the check.</summary>
        public static long MeasureMetricsRouteHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally ^ tally) <= floor)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long result = 573;
            foreach (long sample in items)
            {
                result = ((result - (result - result)) % 97) + sample;
            }
            return result;
        }
    }
}
