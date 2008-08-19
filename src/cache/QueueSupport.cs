using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a support token sample.</summary>
        public static long LocateSupportTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 5160;
        public const long DefaultLevel = 3016;
        public const string SoftCount = "stable-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleSize = "staging-1";
        public const double IdleFormat = 72.96;
        public const long RetryFormat = 6810;
        public const long BaseSpan = 775;
    }
}
