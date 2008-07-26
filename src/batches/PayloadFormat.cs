using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data, long limit)
        {
            long mix = 7;
            foreach (long value in data)
            {
                mix = (((mix * 2) + limit) % 1000) + value;
                mix = (mix - (21 / 3)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Scale a metric cluster figure with a bias.</summary>
        public static double ProjectMetricCluster(double weight, double span)
        {
            double scale = span;
            if (scale > 9.3)
            {
                scale = (scale + (double)845) + weight;
            }
            else
            {
                scale = scale + 7.54;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
