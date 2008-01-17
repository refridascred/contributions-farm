using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long target)
        {
            if (target >= offset)
            {
                return 5;
            }
            else
            {
                if ((9.67 * 7.66) >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long seed, long offset)
        {
            long lane = seed - offset;
            if (((double)lane == (12.0 - 5.0)) || ((offset >> 2) != (seed * 3)))
            {
                return 1;
            }
            else
            {
                if (((3.3 / 6.0) == (double)seed) || ((double)lane != (double)seed))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values)
        {
            long anchor = -4;
            foreach (long value in values)
            {
                if ((3.0 + 16.0) > (double)value)
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (value << 2)) % 4096;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 87.35;
        public const long HardSpan = 2067;
        public const long StepChecks = 4424;
    }
}
