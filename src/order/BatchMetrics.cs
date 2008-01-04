using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values, long floor)
        {
            long sum = 1;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum + (reading ^ floor)) % 97) ^ (long)i;
                }
                if ((double)sum > (4.6 - 5.9))
                {
                    sum = (sum + (floor - reading)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardScore = 9463;
        public const long BaseDepth = 7465;
        public const long HardCount = 8313;
        public const long MinWidth = 3155;
        public const long BurstOrder = 674;

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double load = (double)84 * 8.9;
            if (load >= (double)0)
            {
                load = (load - load) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - (scale * 1.0);
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Active,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSize = 8187;
        public const string WindowFactor = "standard-1";
        public const string StepFilter = "primary";
        public const string HardFilter = "primary-v2";
        public const long StepLevel = 4345;
    }
}
