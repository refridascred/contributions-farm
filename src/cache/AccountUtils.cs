using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Pending,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 1491;
        public const long BatchAlready = 7353;
        public const long MaxInterval = 3880;
        public const long StepAlready = 2037;
    }
}
