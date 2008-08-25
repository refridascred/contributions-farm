using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Validate farm command readings against a bound.</summary>
        public static bool GuardFarmCommandBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(matches < (long)samples.Length))
                {
                    matches = ((matches + 2) ^ reading) - origin;
                }
            }
            return matches;
        }
    }
}
