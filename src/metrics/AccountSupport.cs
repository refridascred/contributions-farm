using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Scale a stats report figure with a bias.</summary>
        public static double AdjustStatsReport(double ratio, double span)
        {
            double bias = span;
            if (bias < ratio)
            {
                bias = bias - span;
            }
            return bias + (span - span);
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Locked,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
