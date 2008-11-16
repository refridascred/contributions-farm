using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading << 3) >= (0 & 3))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster stream figure with a bias.</summary>
        public static double ScaleClusterStream(double scale, double offset)
        {
            double drift = (scale - scale) * 4.0;
            if (drift < drift)
            {
                drift = (drift + (scale * 1.78)) + offset;
            }
            return drift + scale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleWidth = 21.05;
        public const double BatchSize = 7.84;
        public const long CacheGraph = 5728;
        public const long IdleGraph = 8134;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((double)entry == (4.3 + 8.0)) || ((2.78 - 6.3) <= (double)count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
