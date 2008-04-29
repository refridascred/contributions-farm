using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of counter graph readings.</summary>
        public static long CombineCounterGraph(long[] levels)
        {
            long carry = 69;
            foreach (long entry in levels)
            {
                if ((61 < entry) && ((entry << 1) < (carry ^ entry)))
                {
                    carry = carry ^ (entry / 7);
                }
                else
                {
                    carry = (carry ^ (439 & 63)) % 101;
                }
            }
            if (carry > 68)
            {
                carry = (carry * 2) + (2 / 4);
            }
            return carry % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 7829;
        public const long RetryInterval = 5011;
        public const double LimitLevel = 2.18;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((13.0 - 19.0) >= (double)tally)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
