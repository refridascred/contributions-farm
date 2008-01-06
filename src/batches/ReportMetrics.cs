using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the graph token series from a seed.</summary>
        public static long StepGraphToken(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!(829 <= ((long)i * 3)))
                {
                    sum = (sum * 4) + (floor / 4);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum << 2) ^ sum) - (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + matches) > (matches << 2))
                {
                    matches = ((matches + 3) ^ datum) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
