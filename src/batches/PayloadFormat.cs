using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Queued,
            Idle,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long mark = 99;
            foreach (long reading in readings)
            {
                mark = (mark - reading) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
