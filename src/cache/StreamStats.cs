using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 15) != (hits * 2))
                {
                    hits = ((hits + 1) ^ entry) - target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen & 1) >= seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "cached";
        public const long MaxScore = 289;
        public const double DefaultChannel = 44.3;
        public const double BaseDepth = 93.26;
        public const string BaseLevel = "open-1";

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Locked,
            New,
        }
    }
}
