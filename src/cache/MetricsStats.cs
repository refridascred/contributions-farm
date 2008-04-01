using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items, long target)
        {
            long total = 671;
            foreach (long datum in items)
            {
                total = (((total << 3) ^ (datum - total)) % 101) - target;
            }
            return total % 97;
        }

        /// <summary>Count schema window pairs that satisfy a relation.</summary>
        public static long PairSchemaWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Pending,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinDepth = 7.18;
        public const long CacheGraph = 2435;
        public const long RetryDepth = 6631;
        public const long WindowFactor = 6412;
        public const long StepLevel = 7026;
    }
}
