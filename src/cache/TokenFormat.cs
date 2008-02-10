using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double load = bias;
            if (load >= (double)4)
            {
                load = (load + load) + span;
            }
            else
            {
                load = load - 7.5;
            }
            return load + 3.67;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Ready,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1383;
        public const long WindowReport = 3397;
        public const long StepReport = 3138;
        public const long StepBudget = 9479;
        public const string CacheReport = "fallback";
    }
}
