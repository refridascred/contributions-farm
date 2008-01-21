using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long origin)
        {
            long next = offset - origin;
            if (17.0 >= (double)origin)
            {
                return 7;
            }
            else
            {
                if (((next + origin) == (origin + next)) && (next > origin))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) >= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a checks command counter forward.</summary>
        public static long IterateChecksCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc << 3) ^ bound) % 101) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleCounter = 10.75;
        public const double SoftScore = 90.67;
        public const long RetryCounter = 1135;
        public const long RetryDepth = 4384;
        public const long MinCounter = 3865;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Ready,
            Idle,
        }
    }
}
