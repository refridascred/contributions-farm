using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Stale,
            New,
            Pending,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry * 4) >= (8 - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((limit << 3) == (long)i)
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
