using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit account editor readings against a rule.</summary>
        public static long CountAccountEditorMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((tally % 24) < tally))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen << 3) != (seen + seen))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }
    }
}
