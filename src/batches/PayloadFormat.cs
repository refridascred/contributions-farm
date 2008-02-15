using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a stats metric counter forward.</summary>
        public static long SeriesStatsMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = (state ^ (seed % 2)) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(datum <= (seen - 874)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long TotalSupportSession(long[] readings, long seed)
        {
            long result = 937;
            foreach (long sample in readings)
            {
                result = ((result + (sample * 4)) % 101) + seed;
            }
            if (result > 59)
            {
                result = (result * 3) + (result / 3);
            }
            return result;
        }
    }
}
