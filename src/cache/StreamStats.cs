using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry * 4) != (offset + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally / 3) == (cell << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = (state + (state - step)) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every counter cluster entry stays within the limit.</summary>
        public static bool GuardCounterClusterLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
