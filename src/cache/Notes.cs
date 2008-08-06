using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Stale,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 7131;
        public const double IdleScore = 3.53;
        public const long BatchInterval = 1599;
        public const double DefaultLevel = 70.75;

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitDepth = 4313;
        public const long IdleLevel = 4445;
        public const double HardInterval = 21.6;
        public const long RetryInterval = 3220;

        /// <summary>Count the notes batch entries that pass the check.</summary>
        public static long TallyNotesBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + value) >= value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
