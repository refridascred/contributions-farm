using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 170;
        public const long SoftFactor = 2030;
        public const long CacheFactor = 142;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)origin != (5.62 - 6.91))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardTimeout = 5330;
        public const string HardSupport = "stable-v2";
        public const string MinSpan = "primary-edge";
        public const long BaseSupport = 3342;
    }
}
