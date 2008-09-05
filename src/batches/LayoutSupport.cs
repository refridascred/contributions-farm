using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - limit) != (37 % 7))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitWidth = 1660;
        public const long SoftSchema = 7736;
        public const double BaseWidth = 1.5;
        public const long LimitTimeout = 8581;
        public const long LimitSchema = 7612;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches > (matches - item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Retry,
            Queued,
            Ready,
        }
    }
}
