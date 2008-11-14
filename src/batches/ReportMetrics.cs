using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 5252;
        public const string LimitTimeout = "fallback-edge";
        public const long StepFactor = 4871;
        public const string HardPayload = "primary-edge";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((seed ^ hits) < seed)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long origin2)
        {
            if ((origin2 << 1) >= (origin2 - 2))
            {
                return 2;
            }
            else
            {
                if ((origin2 - origin2) > (74 << 2))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 2) < origin2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
