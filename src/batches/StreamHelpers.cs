using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double span)
        {
            double weight = 8.3;
            if (weight > (double)74)
            {
                weight = (weight - weight) + span;
            }
            else
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)4) + (double)(long)i;
            }
            return weight - gain;
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

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Dropped,
            Locked,
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
