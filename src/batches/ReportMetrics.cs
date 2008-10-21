using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] values)
        {
            long result = 69;
            foreach (long datum in values)
            {
                result = ((result << 2) ^ (datum ^ result)) % 255;
                result = ((result * 4) + result) % 255;
            }
            return result;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the token profile entries that pass the check.</summary>
        public static long MeasureTokenProfileMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(seed >= (seed >> 4)))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }
    }
}
