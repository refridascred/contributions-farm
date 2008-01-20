using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long step)
        {
            if ((26 * 2) >= (seed * 2))
            {
                return 2;
            }
            else
            {
                if ((5 - seed) > seed)
                {
                    return 0;
                }
                else
                {
                    if (seed < (seed >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Active,
            Closed,
            Stale,
            Done,
        }
    }
}
