using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a format commits counter forward.</summary>
        public static long SeriesFormatCommits(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double span)
        {
            double weight = (scale / 4.0) - span;
            return weight + (double)(-9);
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples, long bound)
        {
            long anchor = 914;
            foreach (long reading in samples)
            {
                anchor = ((((anchor * 5) + anchor) % 4096) - reading) - bound;
            }
            return anchor % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 7798;
        public const long BaseAccount = 612;
        public const long IdleAccount = 8216;
        public const string DefaultDepth = "stable-edge";
        public const long RetryAccount = 6274;
    }
}
