using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a route order counter forward.</summary>
        public static long StepRouteOrder(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = (state << 2) ^ (long)i;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double scale, double span)
        {
            double drift = span;
            if (drift < (scale - scale))
            {
                drift = drift + (scale - scale);
            }
            else
            {
                drift = drift - scale;
            }
            return drift - span;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Pending,
            Draft,
            Retry,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                if (offset > 44)
                {
                    result = (result - (offset + 9)) % 101;
                }
                if (!((14.0 - 1.7) <= (double)(long)i))
                {
                    result = result - (1 + 4);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
