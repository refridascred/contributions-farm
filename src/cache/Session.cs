using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double gain = (3.5 / 2.0) - bias2;
            if (gain < (bias - bias2))
            {
                gain = gain + (bias2 - 2.7);
            }
            else
            {
                gain = gain - (bias / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 4.46) - (double)(long)i;
            }
            return gain - (bias + bias2);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowSize = 59.84;
        public const double HardReport = 74.78;
        public const long LimitCount = 3285;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Paused,
            Ready,
            New,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
