using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a metrics context sample.</summary>
        public static long LookupMetricsContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((bound << 2) <= (149 - item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1066;
        public const long MaxCount = 5724;
        public const long LimitCluster = 3322;
    }
}
