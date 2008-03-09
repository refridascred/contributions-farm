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

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Pending,
            Queued,
            Stale,
            Failed,
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
