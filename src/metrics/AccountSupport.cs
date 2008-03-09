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

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings, long bound)
        {
            long carry = 52;
            foreach (long value in readings)
            {
                if ((carry + 5) > value)
                {
                    carry = (carry + (carry >> 5)) % 4096;
                }
                if ((double)bound > (double)(long)readings.Length)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
