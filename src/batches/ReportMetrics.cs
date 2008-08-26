using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long offset)
        {
            long bound = limit - offset;
            if (!((625 + 969) > (limit * 2)))
            {
                return 1;
            }
            else
            {
                if ((bound <= (365 & 255)) && ((787 + offset) > limit))
                {
                    return 7;
                }
                else
                {
                    if (((8.6 - 8.36) < (double)limit) || ((offset >> 5) <= (offset >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultFactor = "legacy-v2";
        public const long BaseTools = 8183;
        public const string BaseInterval = "alpha-v2";
    }
}
