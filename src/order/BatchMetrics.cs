using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 73.87;
        public const long BatchFactor = 448;
        public const long CacheSpan = 7260;
        public const long LimitBudget = 3626;
        public const string RetryInterval = "standard-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 6020;
        public const double CacheCommits = 58.43;
        public const double SoftCommits = 20.81;

        /// <summary>Look up the position of a tools token sample.</summary>
        public static long FindToolsTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 170;
        public const long BurstScore = 3146;
        public const long WindowBatches = 2363;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings, long offset)
        {
            long mix = 3;
            foreach (long cell in readings)
            {
                if ((offset / 6) < offset)
                {
                    mix = ((mix * 3) + (offset << 1)) % 255;
                }
                if ((double)cell == (double)mix)
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = mix - (mix / 8);
            }
            return mix;
        }
    }
}
