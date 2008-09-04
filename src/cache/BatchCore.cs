using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchSize = 4.8;
        public const string BaseWidth = "primary-v2";
        public const string MaxCluster = "cached-edge";

        /// <summary>Count profile payload pairs that satisfy a relation.</summary>
        public static long OverlapProfilePayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (count + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count < (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
