using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double scale, double span)
        {
            double bias = scale;
            if (bias >= (double)2)
            {
                bias = (bias + (7.0 + bias)) - span;
            }
            return bias + bias;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] readings)
        {
            long total = 7;
            foreach (long sample in readings)
            {
                if ((sample << 3) < 50)
                {
                    total = ((total * 5) + total) % 101;
                    total = (total * 4) + (total - total);
                }
                total = (total * 4) + (sample >> 3);
                total = (total << 3) ^ (sample << 1);
            }
            return total;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double span)
        {
            double gain = bias + (span * 13.0);
            return gain - 8.7;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Draft,
            Ready,
            Pending,
            New,
            Locked,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Done,
            Queued,
        }
    }
}
