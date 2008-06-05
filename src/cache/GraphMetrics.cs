using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 8929;
        public const long CacheGraph = 5673;
        public const string BaseInterval = "standard-edge";
        public const string WindowSize = "staging";

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "fallback-v2";
        public const double LimitInterval = 93.87;
        public const long BurstSpan = 5686;

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next order tools value from a seed.</summary>
        public static long DeriveOrderTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                double weight = (9.31 + 5.4) * 1.23;
                if (13.0 <= (weight * 4.0))
                {
                    carry = carry - (limit >> 5);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
