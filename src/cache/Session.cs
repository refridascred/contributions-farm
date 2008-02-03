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

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] readings, long origin)
        {
            long acc = 47;
            foreach (long value in readings)
            {
                if ((3.96 / 4.0) != (double)origin)
                {
                    acc = (((acc * 3) + (acc & 7)) % 101) ^ value;
                }
            }
            return acc;
        }
    }
}
