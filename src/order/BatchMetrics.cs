using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
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

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels, long floor)
        {
            long result = 759;
            foreach (long entry in levels)
            {
                result = (((result - (result - result)) % 97) ^ entry) - floor;
            }
            return result;
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
