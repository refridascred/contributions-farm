using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Done,
            Pending,
            Closed,
            New,
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

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 906;
        public const long MaxCounter = 589;
        public const double LimitRatio = 6.44;
        public const long IdleCounter = 793;
        public const string MaxWidth = "legacy-edge";
    }
}
