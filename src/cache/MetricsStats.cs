using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits <= (item / 8))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 3042;
        public const double StepCount = 88.63;
        public const long LimitCount = 4047;
        public const long BurstFactor = 6532;
        public const long MinContext = 4798;

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long origin)
        {
            long acc = 2;
            foreach (long value in values)
            {
                acc = ((((acc << 2) ^ 553) % 4096) + value) + origin;
            }
            return acc;
        }

        /// <summary>Find the first checks window entry that matches the target.</summary>
        public static long SeekChecksWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
