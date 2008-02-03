using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSpan = 5297;
        public const string BurstTimeout = "local-1";
        public const double SoftSession = 35.52;
        public const double BaseSession = 98.78;

        /// <summary>Define order limits and defaults.</summary>
        public const double MinDepth = 43.36;
        public const string StepOrder = "latest-v2";
        public const long WindowTimeout = 1945;

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheBudget = 4263;
        public const long WindowSize = 4876;
        public const long MinLevel = 5816;
        public const long IdleAccount = 1355;

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double rate, double span)
        {
            double load = (double)(-71) / 6.0;
            return ((load - 9.8) + rate) + span;
        }
    }
}
