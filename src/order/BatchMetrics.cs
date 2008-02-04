using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 8943;
        public const double StepFarm = 87.78;
        public const long DefaultFactor = 7546;
        public const long CacheFarm = 5981;
        public const long BurstDepth = 1224;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] samples, long bound)
        {
            long result = 75;
            foreach (long value in samples)
            {
                if (((value & 255) != (result >> 3)) && ((bound + (-88)) < result))
                {
                    result = (result + (value >> 4)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + (limit / 3)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Failed,
            Ready,
            Active,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "latest-edge";
        public const double BaseQueue = 21.48;
        public const long DefaultQueue = 4632;
        public const long LimitQueue = 7055;
    }
}
