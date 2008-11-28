using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit checks command readings against a rule.</summary>
        public static long MeasureChecksCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen + reading) != (reading % 97))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "legacy";
        public const long MinScore = 6362;
        public const double SoftSize = 23.53;
        public const double LimitBatches = 71.09;
        public const double BurstCount = 1.47;

        /// <summary>Rank context payload input into a small class.</summary>
        public static long SortContextPayload(long floor, long offset)
        {
            if (((double)offset != (0.3 + 0.33)) || ((17.0 + 18.0) >= (double)offset))
            {
                return 6;
            }
            else
            {
                if (((floor + offset) > offset) && (7.35 <= (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) != (floor - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset > 18.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
