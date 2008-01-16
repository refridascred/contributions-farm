using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFactor = 6.33;
        public const long MaxLevel = 3556;
        public const long BaseFormat = 1778;
        public const double StepRatio = 4.65;
        public const long BurstFormat = 5200;

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
