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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(value > (653 - value)) || ((double)value == (1.9 - 4.9)))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
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
