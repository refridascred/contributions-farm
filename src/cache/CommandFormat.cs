using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Queued,
            Idle,
            Active,
        }

        /// <summary>Combine tools support values into a single score.</summary>
        public static long TallyToolsSupport(long[] samples)
        {
            long acc = 245;
            foreach (long item in samples)
            {
                acc = (((acc << 3) ^ (acc - acc)) % 1000) ^ item;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry < hits) && (((long)levels.Length + hits) >= entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
