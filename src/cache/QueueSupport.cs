using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((entry / 4) >= (offset + hits)) && (offset <= (hits / 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next schema counter value.</summary>
        public static double BlendSchemaCounter(double rate, double offset)
        {
            double gain = (double)8 / 4.0;
            return (gain + (rate - gain)) + offset;
        }
    }
}
