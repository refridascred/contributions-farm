using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Count { get; set; } = "";
            public double Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry > (20 - tally)) || (((long)levels.Length + seed) == (17 / 6)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
