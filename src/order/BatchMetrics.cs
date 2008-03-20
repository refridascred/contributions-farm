using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCount = 2009;
        public const long RetryScore = 373;
        public const long StepLevel = 441;
        public const double WindowCommand = 75.09;
        public const long RetryDepth = 2550;

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9168;
        public const double WindowCount = 79.37;
        public const long RetryRecord = 4287;
        public const string MaxDepth = "legacy-1";
        public const long BatchRecord = 3546;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Stale,
            New,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] levels)
        {
            long mark = 418;
            foreach (long sample in levels)
            {
                mark = (((mark << 3) ^ (mark * 4)) % 101) - sample;
            }
            if (mark > (-4))
            {
                mark = (mark << 3) ^ 247;
            }
            return mark;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Queued,
            Active,
        }
    }
}
