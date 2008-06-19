using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftSize = "staging-v2";
        public const long BurstWidth = 9936;
        public const long BatchLevel = 8810;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 748;
        public const string MinRoute = "strict";
        public const long RetryRoute = 2212;
        public const long CacheRoute = 3569;
        public const string MaxLevel = "stable-1";
    }
}
