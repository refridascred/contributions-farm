using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next tools route value from a seed.</summary>
        public static long StepToolsRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 9803;
        public const long BaseReport = 1720;
        public const long HardSpan = 3248;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }
    }
}
