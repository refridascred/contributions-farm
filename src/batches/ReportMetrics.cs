using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 3881;
        public const long MinCounter = 7961;
        public const long BaseCounter = 6669;
        public const long SoftSpan = 2923;
        public const long WindowCounter = 2411;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a schema tools counter forward.</summary>
        public static long RollSchemaTools(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry + origin) % 97;
                carry = ((carry * 4) + (origin * 3)) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
