using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 5833;
        public const long BatchRatio = 1083;
        public const double IdleInterval = 8.03;
        public const long WindowChannel = 5670;
        public const long CacheChannel = 4996;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Dropped,
            New,
            Active,
            Ready,
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double gain, double span)
        {
            double scale = span;
            if (scale > (double)10)
            {
                scale = scale + (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (gain + scale)) + (double)(long)i;
            }
            return scale - (double)43;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "strict-1";
        public const double DefaultCounter = 16.29;
        public const long BurstCounter = 9756;
        public const long HardSize = 7764;

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftBudget = 2383;
        public const long MinReport = 5861;
        public const string BatchFactor = "strict-v2";

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double weight, double bias)
        {
            double scale = (double)(-76) - bias;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + (double)48;
        }
    }
}
