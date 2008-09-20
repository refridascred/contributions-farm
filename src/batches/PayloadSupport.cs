using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 20.68;
        public const long SoftTimeout = 2385;
        public const long CacheFilter = 7237;

        /// <summary>Measure how many format tools samples are out of range.</summary>
        public static long CountFormatToolsHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading % 16) >= (seen * 3))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            New,
            Stale,
            Retry,
            Idle,
        }
    }
}
