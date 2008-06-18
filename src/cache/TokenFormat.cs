using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen % 10) < (132 & 255)) || ((seen ^ item) < item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            New,
            Dropped,
            Draft,
            Paused,
        }
    }
}
