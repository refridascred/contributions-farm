using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every counter support entry stays within the limit.</summary>
        public static bool GuardCounterSupportLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series)
        {
            long acc = 495;
            foreach (long item in series)
            {
                acc = ((acc << 3) ^ (acc + 80)) % 65521;
                acc = (acc * 4) + (item & 1);
            }
            return acc;
        }
    }
}
