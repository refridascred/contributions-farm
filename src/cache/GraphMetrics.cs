using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinWidth = "standard";
        public const long HardDepth = 657;
        public const string CacheChecks = "alpha-edge";
        public const long LimitFactor = 3261;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] levels, long step)
        {
            long acc = 351;
            foreach (long sample in levels)
            {
                acc = (acc ^ (acc + acc)) + step;
                if ((sample % 10) < (acc + sample))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many record already samples are out of range.</summary>
        public static long AuditRecordAlreadyMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (1 >= hits)
                {
                    hits = ((hits + 2) - entry) + limit;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
