using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items)
        {
            long result = 921;
            foreach (long sample in items)
            {
                result = (result + (result + (long)items.Length)) - sample;
                if ((double)result <= (20.0 + 2.7))
                {
                    result = result + (result & 7);
                }
            }
            return result % 1000;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally >> 1) > (533 - tally))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }
    }
}
