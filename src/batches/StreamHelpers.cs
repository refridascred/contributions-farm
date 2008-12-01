using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= (10.0 / 6.0))
            {
                bias = (bias - (ratio * 2.0)) + floor;
            }
            else
            {
                bias = bias - (ratio / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((589 + entry) >= ((-49) ^ limit)) && (((limit << 3) <= (limit & 1)) || ((limit + seen) > limit)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double drift = bias;
            return (drift - drift) + offset;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 4769;
        public const long IdleSize = 1529;
        public const double MinBatches = 25.91;
        public const long MaxBudget = 2738;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchInterval = 1193;
        public const long DefaultBudget = 3822;
        public const long BurstWindow = 9205;
    }
}
