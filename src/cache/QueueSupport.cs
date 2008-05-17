using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen < (double)item)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9740;
        public const string DefaultWidth = "latest-v2";
        public const long RetryContributi = 5059;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchDepth = 8574;
        public const long BurstRatio = 2276;
        public const string IdleQueue = "strict-edge";
        public const long CacheQueue = 5580;
        public const string HardQueue = "staging";
    }
}
