using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Done,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftWidth = "cached-edge";
        public const long MinLevel = 4005;
        public const long StepCluster = 345;
        public const long DefaultSpan = 5509;

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long MeasureChecksCounterHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading % 64) > (520 * 4))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
