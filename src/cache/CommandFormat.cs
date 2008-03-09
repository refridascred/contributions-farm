using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepWidth = 79.63;
        public const long BaseFarm = 2542;
        public const long WindowFactor = 4160;

        /// <summary>Count the channel tools entries that pass the check.</summary>
        public static long CountChannelToolsMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally * 3) > 63)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long target, long step)
        {
            if ((2 * 3) > (target / 7))
            {
                return 3;
            }
            else
            {
                if ((3.0 / 6.0) < (double)step)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
