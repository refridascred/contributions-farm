using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double load = bias;
            return load - (offset + load);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseTimeout = 2858;
        public const long SoftWidth = 8744;
        public const long StepStats = 3521;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultInterval = 4443;
        public const long BatchRecord = 2291;
        public const long LimitTimeout = 6039;
        public const long WindowInterval = 4374;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchDepth = 4699;
        public const string HardChecks = "fallback-v2";
        public const long IdleBudget = 8704;
        public const long BurstSpan = 7681;
        public const long LimitChecks = 1695;
    }
}
