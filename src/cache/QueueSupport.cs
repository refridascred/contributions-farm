using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - seed) >= (seed + 717))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first format route entry that matches the target.</summary>
        public static long LocateFormatRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
