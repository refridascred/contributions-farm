using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchBudget = 6501;
        public const long LimitQueue = 9534;
        public const long CacheTimeout = 5194;
        public const long StepFactor = 6253;
        public const long SoftQueue = 1493;

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 4139;
        public const string MaxChannel = "staging";
        public const string BaseChannel = "standard-1";
    }
}
