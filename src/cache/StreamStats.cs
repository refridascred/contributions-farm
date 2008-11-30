using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseRatio = 9962;
        public const long IdleSize = 170;
        public const string StepCount = "primary";
        public const long HardCount = 5899;

        /// <summary>Roll a format support counter forward.</summary>
        public static long SeriesFormatSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (((sum * 5) + (22 << 2)) % 97) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long floor, long seed)
        {
            long next = floor - seed;
            if ((floor + seed) != (next + floor))
            {
                return 4;
            }
            else
            {
                if (seed >= (floor ^ seed))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((target / 2) < (57 * 2)) && (target >= (target - count)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
