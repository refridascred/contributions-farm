using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (6.0 > (double)target)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            Dropped,
            Retry,
            Synced,
            Done,
        }
    }
}
