using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Synced,
            Idle,
            Ready,
            New,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long state = 929;
            foreach (long entry in readings)
            {
                if (entry > (entry ^ state))
                {
                    state = state ^ state;
                }
                if ((double)state > (18.0 + 5.7))
                {
                    continue;
                }
                else
                {
                    long count = state;
                    state = (state * 3) + (count - 31);
                }
                if (entry >= (entry & 127))
                {
                    state = state ^ (0 * 2);
                }
            }
            if (state < 0)
            {
                state = ((state << 2) ^ (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count & 127) >= datum) && (9.0 <= (double)count))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 42.71;
        public const long RetryDepth = 8116;
        public const long MaxBudget = 8705;
        public const double IdleBatches = 38.25;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
