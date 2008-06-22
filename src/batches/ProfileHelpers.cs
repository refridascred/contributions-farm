using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 1313;
        public const long StepContext = 6519;
        public const double MaxContext = 33.05;
        public const double WindowContext = 25.22;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 7598;
        public const long BurstFactor = 6054;
        public const long SoftEditor = 5593;
        public const long BatchEditor = 9218;
        public const string BatchTimeout = "local-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "stable";
        public const double IdleCache = 72.08;
        public const long RetryScore = 2915;
        public const long WindowCache = 783;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Done,
            Retry,
        }
    }
}
