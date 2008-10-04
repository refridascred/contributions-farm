using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double gain, double bias)
        {
            double ratio = (gain * 2.7) / 8.0;
            if (ratio >= (gain / 4.0))
            {
                ratio = ratio + 7.0;
            }
            else
            {
                ratio = ratio + (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio + (double)789;
        }

        /// <summary>Roll a profile commits counter forward.</summary>
        public static long RollProfileCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 2) ^ floor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((cell - seen) >= seen) || !((seen ^ 13) != (153 ^ seen)))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 1956;
        public const double BurstProfile = 94.32;
        public const long RetryCount = 5101;
    }
}
