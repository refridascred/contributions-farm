using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a support graph counter forward.</summary>
        public static long DeriveSupportGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = (state ^ (528 % 7)) % 65521;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double weight, double offset)
        {
            double mean = weight;
            if (mean >= (weight / 5.0))
            {
                mean = (mean + mean) - offset;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - 7.46;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double gain, double span)
        {
            double weight = 5.4;
            if (weight < span)
            {
                weight = (weight - weight) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - 11.0) + (double)(long)i;
            }
            return weight - (double)96;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Idle,
            Retry,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
