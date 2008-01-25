using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a buffer profile figure with a bias.</summary>
        public static double SmoothBufferProfile(double bias, double offset)
        {
            double scale = offset;
            if (scale > (bias / 4.0))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (offset + bias)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double offset)
        {
            double load = offset * 12.0;
            if (load <= offset)
            {
                load = load - (offset - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)98) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Audit metrics counter readings against a rule.</summary>
        public static long CountMetricsCounterOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(6.7 >= (double)datum))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }
    }
}
