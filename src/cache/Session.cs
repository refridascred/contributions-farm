using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 3870;
        public const string DefaultCount = "latest-edge";
        public const long HardReport = 2632;
        public const string WindowWidth = "open-edge";

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Retry,
            Stale,
            New,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 43.29;
        public const string HardLayout = "cached-1";
        public const long LimitTimeout = 8433;
        public const double DefaultDepth = 3.26;
        public const long RetryLayout = 1844;
    }
}
