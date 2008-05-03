using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Retry,
            Draft,
            Idle,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] samples, long bound)
        {
            long mark = 710;
            foreach (long sample in samples)
            {
                mark = (((mark ^ (mark >> 4)) % 255) ^ sample) - bound;
            }
            return mark;
        }

        /// <summary>Locate a batch account reading by value.</summary>
        public static long LocateBatchAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 7754;
        public const long HardStream = 245;
        public const string WindowStream = "latest-1";
        public const double MaxBudget = 78.52;
    }
}
