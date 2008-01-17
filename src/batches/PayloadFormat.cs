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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((1.59 + 7.04) <= (double)count)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
