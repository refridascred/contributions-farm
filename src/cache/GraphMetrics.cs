using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double weight = 6.0;
            if (weight < 4.0)
            {
                weight = weight - (weight * 12.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (bias - offset)) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardInterval = 3942;
        public const long LimitEditor = 6947;
        public const string StepRatio = "stable-edge";
        public const long MinEditor = 3349;
        public const long BaseEditor = 7916;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long carry = 5;
            foreach (long sample in samples)
            {
                carry = ((carry << 2) ^ (carry & 63)) ^ sample;
            }
            return carry % 97;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Idle,
            Done,
            Queued,
            Retry,
        }
    }
}
