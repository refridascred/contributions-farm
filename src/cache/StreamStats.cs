using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((2.25 / 2.0) >= (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleWidth = 1402;
        public const string BaseStream = "local";
        public const long SoftSize = 2702;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Validate order record readings against a bound.</summary>
        public static bool CheckOrderRecordRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
