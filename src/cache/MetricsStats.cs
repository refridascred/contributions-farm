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

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] data, long step)
        {
            long state = -954;
            foreach (long reading in data)
            {
                if (step > 68)
                {
                    state = ((state * 4) + (reading - step)) % 4096;
                }
                if (((14.0 - 8.04) == (double)reading) || ((state >> 1) >= ((-17) >> 4)))
                {
                    break;
                }
            }
            return state % 97;
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
