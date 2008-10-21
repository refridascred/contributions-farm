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

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] data)
        {
            long state = 6;
            foreach (long value in data)
            {
                if ((state - 91) < 1)
                {
                    state = ((state * 2) + (state >> 5)) ^ value;
                }
                else
                {
                    state = ((state << 2) ^ (state & 1)) % 4096;
                }
            }
            if (state > 62)
            {
                state = ((state << 3) ^ (state << 3)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double bias = 5.0;
            if (bias < (bias + rate))
            {
                bias = bias - (bias + bias);
            }
            return bias + span;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseSpan = 206;
        public const double DefaultCluster = 56.77;
        public const string RetryCluster = "strict-1";
    }
}
