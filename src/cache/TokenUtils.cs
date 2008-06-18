using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitWidth = 55.62;
        public const double BurstSpan = 68.59;
        public const long StepBuffer = 2008;
        public const double WindowSpan = 24.57;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen / 7) < seen)
                {
                    seen = ((seen + 2) + item) - offset;
                }
            }
            return seen;
        }
    }
}
