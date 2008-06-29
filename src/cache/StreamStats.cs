using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate already window samples.</summary>
        public static long ScoreAlreadyWindow(long[] samples, long floor)
        {
            long total = 6;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (((total << 3) ^ (67 >> 5)) % 97) ^ (long)i;
                    total = (total + (-1)) % 1000;
                }
                if (((floor << 3) >= (floor + 600)) || (543 <= value))
                {
                    total = total ^ (45 >> 2);
                }
                else
                {
                    total = (total << 2) ^ (total & 3);
                }
                total = ((total * 5) + (total * 4)) % 101;
            }
            return total;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double scale = (double)(0 / 2);
            if (scale >= (span * 6.0))
            {
                scale = scale - (double)125;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - (double)84;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Stale,
            Synced,
        }
    }
}
