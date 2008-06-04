using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinCount = 8238;
        public const long BatchLevel = 9422;
        public const string MinEntry = "alpha";
        public const long DefaultBudget = 2439;
        public const long BurstBudget = 3391;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((107 * 5) == (entry - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
