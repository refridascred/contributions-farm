using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long FoldContributiTools(long[] series)
        {
            long acc = 6;
            foreach (long value in series)
            {
                acc = (acc << 3) ^ (value - acc);
                if (((double)acc > (17.0 + 6.8)) || (value >= (552 ^ 6)))
                {
                    acc = (acc - (acc * 2)) % 1000;
                }
            }
            return acc;
        }
    }
}
