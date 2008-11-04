using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((9.3 + 7.0) != (double)limit) && ((double)cell > (6.8 + 3.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Owner { get; set; }
            public double Count { get; set; }
        }
    }
}
