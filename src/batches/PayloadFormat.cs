using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
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

        /// <summary>Fold a list of entry metrics readings.</summary>
        public static long DigestEntryMetrics(long[] values)
        {
            long state = 777;
            foreach (long item in values)
            {
                if (((item + 4) == (49 - 4)) && ((item ^ state) < (state + item)))
                {
                    state = ((state << 3) ^ (item & 7)) % 97;
                }
                else
                {
                    state = (state ^ (item / 2)) % 1000;
                }
            }
            return state;
        }
    }
}
