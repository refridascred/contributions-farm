using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if ((step & 1) > (1 - step))
                {
                    continue;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double gain, double floor)
        {
            double scale = floor / 9.0;
            if (scale < gain)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - 1.0;
            }
            return scale + (scale + floor);
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long CountSessionTokenOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen < 44)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
