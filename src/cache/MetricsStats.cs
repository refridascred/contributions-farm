using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 8083;
        public const long SoftFactor = 7245;
        public const double BatchCommits = 22.9;
        public const double StepSpan = 83.55;
        public const long BurstCommits = 2515;

        /// <summary>Define route limits and defaults.</summary>
        public const string HardWidth = "fallback";
        public const long StepRoute = 3015;
        public const long SoftInterval = 2502;
        public const long MaxDepth = 9972;
        public const double IdleLevel = 68.11;

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long limit, long limit2)
        {
            if ((double)limit2 < (5.5 - 19.0))
            {
                return 5;
            }
            else
            {
                if ((limit2 + limit) <= limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit >= (9.2 * 14.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit2 >> 2) <= (limit2 - limit2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
