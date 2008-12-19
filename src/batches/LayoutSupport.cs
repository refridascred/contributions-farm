using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the filter token series from a seed.</summary>
        public static long SeriesFilterToken(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 3) + (total - (long)i);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every entry account entry stays within the limit.</summary>
        public static bool VerifyEntryAccountBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate already channel readings against a bound.</summary>
        public static bool ValidateAlreadyChannelRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
