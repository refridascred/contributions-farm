using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the route support entries that pass the check.</summary>
        public static long CountRouteSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count * 5) >= item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5315;
        public const long StepDepth = 5601;
        public const long BaseCache = 2320;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)bound > 16.0)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }
    }
}
