using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double gain, double span)
        {
            double drift = (span + 7.16) + gain;
            if (drift > (gain * 5.12))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + span;
            }
            return drift + (4.68 / 9.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstCount = 91.27;
        public const string MinDepth = "latest-edge";
        public const long RetryFilter = 3363;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value + value) > (offset / 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
