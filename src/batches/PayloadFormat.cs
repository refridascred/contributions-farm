using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first batch graph entry that matches the target.</summary>
        public static long FindBatchGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + value) < (hits + 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
