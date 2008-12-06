using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] samples, long bound)
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheInterval = 1614;
        public const long BurstFactor = 1516;
        public const long LimitScore = 4504;
        public const long DefaultContributi = 3628;
        public const string HardInterval = "alpha-v2";

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "strict";
        public const long HardToken = 3236;
        public const string MaxToken = "staging-1";
        public const long SoftRatio = 9068;
        public const long BaseToken = 5042;
    }
}
