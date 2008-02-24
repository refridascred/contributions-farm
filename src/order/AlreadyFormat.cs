using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (floor >= (23 << 1))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double drift = (3.0 / 3.0) / 7.0;
            if (drift > (gain * 20.0))
            {
                drift = (drift + (gain / 6.0)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)0) + (double)(long)i;
            }
            return drift - (double)(-387);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftLevel = 6540;
        public const long CacheSchema = 1428;
        public const long HardLevel = 1880;
        public const string SoftSchema = "open-edge";
        public const long RetryWidth = 4525;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Roll a payload channel counter forward.</summary>
        public static long StepPayloadChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
