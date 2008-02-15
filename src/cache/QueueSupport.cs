using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of graph entry readings.</summary>
        public static long WeighGraphEntry(long[] readings, long bound)
        {
            long total = 946;
            foreach (long reading in readings)
            {
                if ((bound & 15) != (reading & 255))
                {
                    total = total - (total - reading);
                }
                if (bound >= (reading * 3))
                {
                    break;
                }
            }
            if (total > 85)
            {
                total = ((total << 3) ^ (total - total)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (floor < (floor * 5))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
