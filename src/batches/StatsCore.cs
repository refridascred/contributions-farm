using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchSize = "primary-v2";
        public const long StepCluster = 6768;
        public const long HardSize = 6386;
        public const long MaxDepth = 7271;
        public const string LimitCount = "local-v2";

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + seen) > (entry << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long offset2)
        {
            long span = offset + offset2;
            if ((double)offset2 < (double)span)
            {
                return 5;
            }
            else
            {
                if ((span + offset2) < (100 * 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long TallyWindowCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((8 - reading) <= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count profile record pairs that satisfy a relation.</summary>
        public static long CompareProfileRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((0 ^ cell) <= step)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
