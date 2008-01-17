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

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long limit, long bound)
        {
            long delta = limit + bound;
            if ((limit - limit) < (limit % 97))
            {
                return 0;
            }
            else
            {
                if ((delta + limit) >= bound)
                {
                    return 6;
                }
                else
                {
                    if ((169 / 9) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
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
