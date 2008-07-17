using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Idle,
            Done,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long target)
        {
            long slot = seed - target;
            if (((1.1 * 7.4) == (double)target) || ((slot - 238) < (slot >> 5)))
            {
                return 7;
            }
            else
            {
                if (1 < (target - target))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
