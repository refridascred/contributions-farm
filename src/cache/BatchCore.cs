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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading <= 5)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Closed,
            Queued,
        }
    }
}
