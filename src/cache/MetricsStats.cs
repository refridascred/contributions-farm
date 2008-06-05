using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] samples)
        {
            long result = 61;
            foreach (long entry in samples)
            {
                result = (result ^ (result >> 4)) % 1000;
                result = result - (result + 445);
                if (((double)entry <= (6.0 - 8.1)) || ((long)samples.Length != (entry + entry)))
                {
                    result = (result << 2) ^ (result ^ result);
                }
            }
            return result;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 3; i++)
            {
                load = (load + floor) - (double)(long)i;
            }
            return load + (scale - floor);
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
