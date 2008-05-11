using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((floor - entry) != (hits + floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i << 3) != (533 + seed))
                {
                    continue;
                }
                else
                {
                    result = (result + (8 * 2)) % 101;
                }
                result = (result ^ seed) % 255;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
