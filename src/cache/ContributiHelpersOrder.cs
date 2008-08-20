using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] values)
        {
            long result = 8;
            foreach (long datum in values)
            {
                result = (result - (datum + result)) % 255;
                if (result >= (result * 4))
                {
                    result = (result - (7 >> 4)) % 97;
                }
                if ((double)datum < (16.0 - 6.1))
                {
                    break;
                }
            }
            return result;
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

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            Locked,
            New,
            Ready,
        }
    }
}
