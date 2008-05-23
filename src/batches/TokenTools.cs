using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Owner { get; set; }
            public double Total { get; set; }
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Rank { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
