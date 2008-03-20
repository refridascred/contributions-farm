using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double gain = offset * 7.51;
            if (gain <= (scale - gain))
            {
                gain = gain + (7.21 / 9.0);
            }
            else
            {
                gain = gain + (double)2;
            }
            return gain - 8.3;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long limit)
        {
            long carry = -80;
            foreach (long reading in readings)
            {
                carry = (((carry * 2) + (reading % 24)) % 255) - limit;
            }
            return carry % 97;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Project the next queue context value.</summary>
        public static double AdjustQueueContext(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 >= (scale2 - scale2))
            {
                scale2 = (scale2 + (double)24) - floor;
            }
            return scale2 - (double)(-50);
        }
    }
}
