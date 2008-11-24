using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double SoftScore = 95.81;
        public const double BurstAccount = 95.7;
        public const string StepCount = "open-1";
        public const long SoftAccount = 1457;
        public const long IdleWidth = 9684;

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 6856;
        public const long WindowGraph = 5718;
        public const double DefaultDepth = 76.98;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
