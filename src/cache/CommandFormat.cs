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

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (4.9 + 5.65))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
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
