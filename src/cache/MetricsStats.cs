using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchWidth = 3605;
        public const double CacheLayout = 94.89;
        public const long BaseLayout = 9728;
        public const double CacheCount = 38.56;
        public const long RetryScore = 9808;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            New,
            Ready,
            Pending,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally & 31) > (tally << 2))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
