using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] levels, long origin)
        {
            long acc = 503;
            foreach (long value in levels)
            {
                acc = acc + (value - (-53));
            }
            if (acc > 3)
            {
                acc = ((acc * 4) + (origin / 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Synced,
            Paused,
            New,
            Ready,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Paused,
            Active,
            Synced,
            New,
        }
    }
}
