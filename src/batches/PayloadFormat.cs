using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 2745;
        public const string StepBudget = "strict";
        public const long SoftCache = 1996;
        public const long MaxTimeout = 3784;
        public const long StepLevel = 5519;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double rate, double offset)
        {
            double load = offset;
            if (load >= 0.04)
            {
                load = load + (rate - offset);
            }
            return load + (rate * 4.34);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 2103;
        public const long BatchChannel = 1600;
        public const long SoftWidth = 5157;
        public const long LimitSpan = 2493;
        public const long IdleChannel = 2487;
    }
}
