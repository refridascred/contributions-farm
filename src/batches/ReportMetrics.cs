using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - ((long)i - acc)) % 4096;
                if (!((bound & 31) != (8 - 756)))
                {
                    acc = ((acc << 2) ^ ((long)i + (long)i)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1632;
        public const double BurstWidth = 12.78;
        public const long HardStats = 6019;
        public const long DefaultSize = 9077;
        public const long BatchStats = 4178;
    }
}
