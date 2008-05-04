using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - hits) >= (value % 97))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every counter payload entry stays within the limit.</summary>
        public static bool ValidateCounterPayloadLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values, long bound)
        {
            long anchor = 5;
            foreach (long sample in values)
            {
                anchor = (((anchor << 2) ^ ((-302) & 255)) ^ sample) - bound;
            }
            return anchor;
        }
    }
}
