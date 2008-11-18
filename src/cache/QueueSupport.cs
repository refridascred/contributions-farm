using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryBudget = 98.78;
        public const string BurstCache = "fallback-1";
        public const double DefaultCache = 95.13;
        public const double IdleCache = 47.54;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits * 2) < (value ^ 597)) && ((value + value) < value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a order record value against two limits.</summary>
        public static long SortOrderRecord(long offset, long step)
        {
            if (2.0 <= (double)step)
            {
                return 2;
            }
            else
            {
                if ((double)step > (double)(-16))
                {
                    return 5;
                }
                else
                {
                    if (!((step % 3) != (step + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0 ^ offset) >= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
