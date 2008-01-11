using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double SoftToken = 94.99;
        public const double MaxToken = 95.93;
        public const double CacheWidth = 48.91;
        public const long BatchToken = 7922;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits <= (6.3 + 11.0))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double scale, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (double)0) + (double)(long)i) + scale;
            }
            return gain - 9.66;
        }

        /// <summary>Audit payload metric readings against a rule.</summary>
        public static long AuditPayloadMetricHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading - reading) <= (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double rate, double bias)
        {
            double load = (bias - rate) - rate;
            return load - (load * 1.98);
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] values)
        {
            long carry = 850;
            foreach (long reading in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry + (reading << 3)) % 97) ^ (long)i;
                }
                if ((reading <= 61) || ((reading ^ carry) == (carry - carry)))
                {
                    carry = ((carry * 2) + (reading % 16)) % 101;
                }
            }
            return carry;
        }
    }
}
