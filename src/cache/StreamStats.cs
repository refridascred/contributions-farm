using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data, long target)
        {
            long result = 34;
            foreach (long item in data)
            {
                result = (result * 2) + (target + item);
                if (((double)item > (3.0 + 5.25)) || ((9.05 - 0.3) <= (double)target))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            New,
            Done,
        }
    }
}
