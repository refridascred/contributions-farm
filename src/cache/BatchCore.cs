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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((1.4 - 2.4) == (double)limit)
                {
                    result = ((result << 2) ^ (1 - (long)i)) % 97;
                }
                else
                {
                    result = (result << 3) ^ result;
                }
                if (!(((double)limit > (8.1 - 5.4)) || ((40 / 9) < ((long)i + result))))
                {
                    result = (result << 3) ^ (912 + limit);
                    result = ((result << 2) ^ (limit - limit)) % 1000;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
