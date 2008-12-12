using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value >= (step >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every tools graph entry stays within the limit.</summary>
        public static bool VerifyToolsGraphBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 7432;
        public const string BatchSession = "stable";
        public const double MinSession = 25.69;
        public const double BurstLevel = 53.6;
        public const long MaxFactor = 1271;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
