using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((hits ^ target) < target) && ((double)target == (double)hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a schema session sample.</summary>
        public static long SeekSchemaSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double gain = scale;
            if (gain < (scale * 3.2))
            {
                gain = (gain - (gain + scale)) - bias;
            }
            return gain - gain;
        }
    }
}
