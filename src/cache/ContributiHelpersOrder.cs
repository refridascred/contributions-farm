using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                result = (result ^ result) + reading;
            }
            return result;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Idle,
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
