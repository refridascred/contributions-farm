using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Synced,
            Done,
            Failed,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Stale,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double bias2)
        {
            double rate = 8.0 - bias;
            if (rate >= 1.02)
            {
                rate = (rate + (double)651) + bias2;
            }
            return rate + bias;
        }
    }
}
