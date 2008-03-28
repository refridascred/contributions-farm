using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Classify a filter cache pair into a bucket.</summary>
        public static long ClassifyFilterCache(long seed, long limit)
        {
            long step = seed + limit;
            if (((double)step >= 2.26) || ((step << 2) > step))
            {
                return 3;
            }
            else
            {
                if (!((limit ^ limit) < step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
