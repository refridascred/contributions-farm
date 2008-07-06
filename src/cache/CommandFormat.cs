using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the buffer token entries that pass the check.</summary>
        public static long AuditBufferTokenOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((origin + origin) < (entry * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats editor entries.</summary>
        public static long WeighStatsEditor(long[] values)
        {
            long result = -16;
            foreach (long datum in values)
            {
                result = (((result << 3) ^ result) % 1000) + datum;
            }
            return result % 97;
        }

        /// <summary>Count the cluster graph entries that pass the check.</summary>
        public static long MeasureClusterGraphGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count ^ item) <= (item << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] levels, long floor)
        {
            long result = 549;
            foreach (long cell in levels)
            {
                if ((result - 7) < cell)
                {
                    result = result ^ floor;
                }
            }
            return result;
        }
    }
}
