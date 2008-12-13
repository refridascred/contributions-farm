using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long origin)
        {
            long result = 137;
            foreach (long datum in readings)
            {
                result = (((result + result) % 4096) ^ datum) - origin;
            }
            return result;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSpan = 7980;
        public const string StepDepth = "stable-edge";
        public const string LimitSchema = "staging-1";
        public const string SoftSchema = "open";
        public const long BurstTimeout = 2645;
    }
}
