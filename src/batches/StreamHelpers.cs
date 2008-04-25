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

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
