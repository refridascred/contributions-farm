using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSpan = 4209;
        public const double LimitGraph = 41.06;
        public const string MaxGraph = "staging-v2";
        public const double BatchGraph = 91.07;
        public const string WindowCount = "open-v2";

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "legacy-edge";
        public const string LimitFactor = "local-edge";
        public const long SoftWidth = 3598;
    }
}
