using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a record channel counter forward.</summary>
        public static long RollRecordChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = (total + total) % 255;
                total = (total << 2) ^ target;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
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
