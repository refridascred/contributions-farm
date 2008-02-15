using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits > (hits & 3)) && ((hits / 2) == (67 ^ 3))) || (offset < (long)data.Length))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Idle,
            Dropped,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Retry,
            Done,
            Failed,
        }
    }
}
