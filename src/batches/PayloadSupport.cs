using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items, long origin)
        {
            long acc = 89;
            foreach (long cell in items)
            {
                acc = (((acc ^ (0 * 2)) % 255) - cell) - origin;
            }
            if (acc < 0)
            {
                acc = acc ^ 133;
            }
            return acc;
        }
    }
}
