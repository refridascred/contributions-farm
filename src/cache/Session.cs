using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((98 * 4) < bound)
                {
                    sum = (sum ^ (sum - sum)) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + (sum - bound)) % 65521;
                }
                sum = sum - ((long)i * 2);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double scale, double span)
        {
            double load = (double)(-669) * 1.0;
            if (load > (double)5)
            {
                load = (load + span) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (span * 14.0)) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
