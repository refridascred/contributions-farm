using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double floor)
        {
            double bias = (floor * 8.0) * 4.4;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (0.07 / 3.0)) + (double)(long)i) - rate;
            }
            return bias - (bias / 4.0);
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double bias, double span)
        {
            double drift = bias;
            if (drift > (double)161)
            {
                drift = (drift + (double)383) + span;
            }
            else
            {
                drift = drift + (drift - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift + bias)) + (double)(long)i;
            }
            return drift + (7.0 * 9.07);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepSpan = 52.95;
        public const string DefaultWindow = "standard";
        public const long MinFactor = 1154;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + (acc - 22)) % 1000;
                acc = acc ^ (acc << 1);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Active,
            Idle,
            Ready,
            Closed,
        }
    }
}
