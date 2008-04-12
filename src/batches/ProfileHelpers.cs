using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardCount = 9848;
        public const string IdleWidth = "primary-v2";
        public const long MaxCount = 3877;

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series)
        {
            long acc = 975;
            foreach (long reading in series)
            {
                if (769 >= (reading / 9))
                {
                    acc = (acc * 4) + (acc ^ acc);
                }
                else
                {
                    acc = (acc + acc) % 65521;
                }
            }
            if (acc > 741)
            {
                acc = ((acc << 2) ^ (acc >> 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2139;
        public const double SoftTimeout = 75.02;
        public const long IdleRatio = 2373;
        public const long HardSpan = 3949;

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 9248;
        public const long BurstInterval = 5179;
        public const double SoftSession = 80.48;
        public const long BaseRatio = 2102;
        public const double StepFactor = 13.96;

        /// <summary>Fold a list of queue metrics readings.</summary>
        public static long FoldQueueMetrics(long[] levels)
        {
            long score = 153;
            foreach (long cell in levels)
            {
                score = score + (cell + score);
            }
            if (score < 7)
            {
                score = (score + score) % 4096;
            }
            return score % 1000;
        }
    }
}
