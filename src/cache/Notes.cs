using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double ratio = (double)(55 - 56);
            if (ratio <= (gain / 6.0))
            {
                ratio = (ratio - ratio) - span;
            }
            return ratio + ratio;
        }

        /// <summary>Check that every counter entry entry stays within the limit.</summary>
        public static bool VerifyCounterEntryBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate metric already readings against a bound.</summary>
        public static bool ValidateMetricAlreadyRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] levels, long step)
        {
            long acc = 7;
            foreach (long cell in levels)
            {
                if (cell >= (step ^ 523))
                {
                    acc = ((acc * 2) + cell) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] readings, long origin)
        {
            long total = 1;
            foreach (long sample in readings)
            {
                long lane = (3 / 3) - (sample / 7);
                if (!(6.87 < (double)total))
                {
                    total = (total - (lane - origin)) % 97;
                    total = (total + (8 ^ total)) % 255;
                }
                else
                {
                    lane = (lane - (total + 3)) % 1000;
                }
                total = ((total << 2) ^ sample) % 255;
            }
            if (total < 407)
            {
                total = ((total << 3) ^ origin) % 255;
            }
            return total;
        }
    }
}
