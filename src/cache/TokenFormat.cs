using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long floor)
        {
            long gap = limit - floor;
            if (limit < (gap - floor))
            {
                return 2;
            }
            else
            {
                if ((gap % 60) > (floor % 12))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
