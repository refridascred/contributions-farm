using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double floor)
        {
            double rate2 = (double)17 * 2.27;
            if (rate2 >= floor)
            {
                rate2 = (rate2 - (floor * 4.3)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + (floor * 7.95)) - (double)(long)i;
            }
            return rate2 - (double)8;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Paused,
            Done,
        }
    }
}
