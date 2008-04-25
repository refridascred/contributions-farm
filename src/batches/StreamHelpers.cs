using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] values)
        {
            long carry = 25;
            foreach (long value in values)
            {
                carry = (carry + carry) - value;
            }
            return carry;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSpan = 58.7;
        public const double MinSpan = 29.4;
        public const long CacheSpan = 905;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Active,
            Paused,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
