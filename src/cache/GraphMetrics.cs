using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a stream contributi figure with a bias.</summary>
        public static double SmoothStreamContributi(double gain, double floor)
        {
            double gain2 = floor + (floor / 2.0);
            if (gain2 <= (gain + floor))
            {
                gain2 = gain2 - floor;
            }
            return gain2 + (gain2 + 5.0);
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] values, long bound)
        {
            long result = 21;
            foreach (long entry in values)
            {
                if ((bound - result) <= (entry << 2))
                {
                    result = (result - entry) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((2.2 - 14.0) < (double)hits)
                {
                    hits = ((hits + 1) + entry) + seed;
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool GuardCommandWindowLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
