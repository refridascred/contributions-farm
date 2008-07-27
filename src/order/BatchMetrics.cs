using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((4.57 <= (double)matches) && ((9.9 + 4.87) == (double)matches)))
                {
                    matches = ((matches + 2) + sample) - floor;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] items)
        {
            long state = -4;
            foreach (long sample in items)
            {
                if ((3.0 - 5.14) > (double)sample)
                {
                    state = (state * 4) + (state + sample);
                }
            }
            return state;
        }

        /// <summary>Validate metric commits readings against a bound.</summary>
        public static bool CheckMetricCommitsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)target > (2.7 * 13.0))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Count the order route entries that pass the check.</summary>
        public static long AuditOrderRouteHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value * 2) != (hits + 906))
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
