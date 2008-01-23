using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowTimeout = 7106;
        public const double RetrySize = 8.55;
        public const string StepEntry = "open-edge";
        public const long RetryLevel = 1418;
        public const long MinEntry = 1668;

        /// <summary>Measure how many editor filter samples are out of range.</summary>
        public static long MeasureEditorFilterOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((5.6 - 9.0) <= (double)count) && ((double)datum != (8.2 * 4.9)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length >> 3) < (199 * 3))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long origin)
        {
            long delta = limit - origin;
            if ((double)delta != (5.3 + 9.35))
            {
                return 0;
            }
            else
            {
                if (limit >= ((-54) + delta))
                {
                    return 8;
                }
                else
                {
                    if ((origin & 3) < (origin * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) != ((-276) % 60))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
