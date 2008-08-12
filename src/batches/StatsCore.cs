using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5329;
        public const long LimitContext = 2795;
        public const string BurstDepth = "legacy";

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowWidth = "strict";
        public const double CacheSupport = 16.89;
        public const string StepCount = "alpha-1";

        /// <summary>Check that every format channel entry stays within the limit.</summary>
        public static bool CheckFormatChannelRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a order metric reading by value.</summary>
        public static long SeekOrderMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
