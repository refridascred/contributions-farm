using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] readings, long bound)
        {
            long anchor = 896;
            foreach (long reading in readings)
            {
                if (!(anchor < (533 ^ (long)readings.Length)))
                {
                    anchor = (((anchor * 4) + bound) % 1000) - reading;
                }
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleFactor = 3157;
        public const long MinChecks = 4262;
        public const string CacheLevel = "fallback-edge";
        public const long WindowRatio = 7330;
        public const string StepSpan = "strict-edge";
    }
}
