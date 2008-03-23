using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
