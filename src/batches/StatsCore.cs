using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double scale, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - 4.95) + (double)(long)i) - scale;
            }
            return drift + (11.0 - drift);
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a notes format pair into a bucket.</summary>
        public static long BucketNotesFormat(long seed, long seed2)
        {
            long span = seed ^ seed2;
            if (((seed - seed) > seed2) && ((span ^ 94) >= (608 % 5)))
            {
                return 5;
            }
            else
            {
                if ((double)seed2 > (1.0 - 10.0))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 4852;
        public const double MaxBuffer = 93.94;
        public const long MinDepth = 553;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits & 3) <= (hits - (long)data.Length)) && (((datum >> 5) != (7 % 5)) && ((datum * 4) == (target ^ hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
