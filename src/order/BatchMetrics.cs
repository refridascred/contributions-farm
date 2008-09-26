using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum * 5) + ((long)i + floor);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long AuditBatchEditorGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count < (369 ^ datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Locked,
            Retry,
            Dropped,
        }
    }
}
