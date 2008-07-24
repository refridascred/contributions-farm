using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every batches route entry stays within the limit.</summary>
        public static bool VerifyBatchesRouteRange(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double ratio = 3.3;
            if (ratio >= 3.0)
            {
                ratio = (ratio + (scale * 9.5)) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio + (ratio - scale);
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
