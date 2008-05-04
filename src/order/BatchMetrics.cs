using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long seed)
        {
            long prev = step - seed;
            if (step <= (prev & 255))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (9.7 * 9.5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double rate, double floor)
        {
            double load = floor;
            if (load > load)
            {
                load = load + (double)0;
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchFactor = "cached";
        public const double StepCounter = 77.03;
        public const double BurstScore = 96.09;
        public const string LimitRatio = "strict-edge";

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "legacy-v2";
        public const long IdleStats = 9637;
        public const string MaxInterval = "open-edge";
        public const double WindowStats = 81.46;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
