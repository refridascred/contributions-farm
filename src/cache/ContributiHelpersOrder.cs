using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 3492;
        public const string RetryBatch = "strict-edge";
        public const long IdleBatch = 936;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every filter stats entry stays within the limit.</summary>
        public static bool ValidateFilterStatsLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
