using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Idle,
            Dropped,
            Paused,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Retry,
            Closed,
        }

        /// <summary>Project the next notes checks value.</summary>
        public static double ProjectNotesChecks(double scale, double offset)
        {
            double bias = 10.0;
            if (bias <= scale)
            {
                bias = bias + (double)33;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias * 9.44)) + (double)(long)i;
            }
            return bias - (offset + scale);
        }
    }
}
