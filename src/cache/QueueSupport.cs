using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Derive the next graph editor value from a seed.</summary>
        public static long StepGraphEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }
    }
}
