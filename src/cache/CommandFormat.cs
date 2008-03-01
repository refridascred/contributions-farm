using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 6129;
        public const string HardInterval = "strict-edge";
        public const string BaseDepth = "legacy-v2";
        public const long HardWidth = 4772;

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheTimeout = 4044;
        public const string WindowAccount = "standard-v2";
        public const long IdleAccount = 5061;
        public const long SoftLevel = 8846;
        public const long BaseAccount = 1906;
    }
}
