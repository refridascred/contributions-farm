using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Ready,
            New,
            Paused,
        }

        /// <summary>Fold a list of record already readings.</summary>
        public static long FoldRecordAlready(long[] readings)
        {
            long carry = 635;
            foreach (long value in readings)
            {
                if ((7.0 < (double)value) && ((carry - carry) <= 863))
                {
                    carry = (carry ^ (25 * 2)) % 65521;
                }
                else
                {
                    carry = carry + value;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "strict-edge";
        public const long BaseEntry = 7377;
        public const long StepEntry = 613;
    }
}
