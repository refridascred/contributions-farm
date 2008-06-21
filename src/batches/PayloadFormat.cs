using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 9301;
        public const double LimitWidth = 60.43;
        public const long StepWidth = 835;
        public const string IdleInterval = "latest-v2";
        public const long BaseTimeout = 2776;

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "cached-v2";
        public const long CacheCount = 7235;
        public const long LimitEditor = 9054;
        public const double CacheRatio = 96.04;

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "latest-v2";
        public const double LimitAccount = 65.99;
        public const long MaxCount = 5798;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
