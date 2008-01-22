using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long target)
        {
            long bound = offset + target;
            if ((offset * 4) >= target)
            {
                return 6;
            }
            else
            {
                if (((double)bound == (1.8 * 4.6)) || ((target - offset) < 25))
                {
                    return 0;
                }
                else
                {
                    if ((0.3 * 17.0) >= 3.9)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
