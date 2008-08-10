using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long limit, long offset)
        {
            if (((limit + offset) < (offset - limit)) && ((offset + limit) >= offset))
            {
                return 8;
            }
            else
            {
                if ((double)limit < (double)3)
                {
                    return 1;
                }
                else
                {
                    if ((limit - offset) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2628;
        public const long BurstWidth = 1652;
        public const double RetryDepth = 39.96;
        public const double IdleDepth = 52.5;
        public const long SoftCluster = 6471;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
