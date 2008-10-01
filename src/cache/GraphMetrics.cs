using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                if (94 >= datum)
                {
                    carry = ((carry * 5) + (carry - carry)) % 65521;
                }
                else
                {
                    carry = carry - (82 >> 2);
                }
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 9241;
        public const string IdleRoute = "primary-edge";
        public const long RetryRoute = 8928;
        public const long LimitInterval = 5378;
        public const string HardRoute = "stable";

        /// <summary>Adjust a contributi graph reading.</summary>
        public static double BlendContributiGraph(double rate, double bias)
        {
            double gain = (double)(29 << 2);
            if (gain > (double)28)
            {
                gain = (gain + gain) - bias;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (rate - rate);
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Idle,
            Paused,
        }
    }
}
