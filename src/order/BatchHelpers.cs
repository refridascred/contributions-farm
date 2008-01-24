using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!!((5 ^ cell) < (seen + (-871))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches % 3) <= (840 + matches))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
