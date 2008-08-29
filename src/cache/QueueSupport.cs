using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Score { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell <= (matches % 100))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate session record readings against a bound.</summary>
        public static bool GuardSessionRecordBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
