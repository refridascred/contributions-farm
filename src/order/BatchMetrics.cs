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

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] data, long offset)
        {
            long anchor = 7;
            foreach (long datum in data)
            {
                if (!((anchor + datum) >= offset))
                {
                    anchor = (anchor - 52) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (5 << 1)) % 65521;
                }
            }
            return anchor % 97;
        }
    }
}
