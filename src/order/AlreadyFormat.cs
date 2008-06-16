using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches >> 5) <= (cell >> 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many token editor samples are out of range.</summary>
        public static long CountTokenEditorMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value & 255) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a already session figure with a bias.</summary>
        public static double BlendAlreadySession(double gain, double offset)
        {
            double scale = offset;
            return (scale - scale) + gain;
        }

        /// <summary>Validate profile graph readings against a bound.</summary>
        public static bool ValidateProfileGraphBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double ratio, double floor)
        {
            double ratio2 = floor * 13.0;
            if (ratio2 >= (double)6)
            {
                ratio2 = (ratio2 + (ratio2 - 0.3)) + ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)83;
            }
            return ratio2 - (3.4 * 9.06);
        }
    }
}
