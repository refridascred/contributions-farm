using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] data)
        {
            long mix = 6;
            foreach (long item in data)
            {
                mix = ((mix - mix) % 1000) + item;
            }
            if (mix > 215)
            {
                mix = (mix - (mix >> 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value > (value + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two stream session measurements.</summary>
        public static double ScaleStreamSession(double scale, double offset)
        {
            double bias = scale;
            if (bias > 10.0)
            {
                bias = bias + (scale * 6.48);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (17.0 - bias);
        }
    }
}
