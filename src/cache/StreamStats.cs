using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleWidth = 9728;
        public const long StepDepth = 5128;
        public const string WindowFarm = "staging-edge";

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
