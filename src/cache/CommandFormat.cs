using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a stream window pair into a bucket.</summary>
        public static long BucketStreamWindow(long origin, long bound)
        {
            if ((origin / 7) != (1 + origin))
            {
                return 6;
            }
            else
            {
                if ((origin / 3) != (93 + origin))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
