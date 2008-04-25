using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Retry,
            New,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinInterval = "alpha-edge";
        public const double CacheAlready = 36.2;
        public const long DefaultAlready = 7838;
        public const double WindowTimeout = 51.89;
        public const double HardAlready = 62.52;
    }
}
