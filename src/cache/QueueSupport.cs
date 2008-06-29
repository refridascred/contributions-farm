using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Closed,
            Dropped,
            Ready,
            New,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally <= (double)target)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series)
        {
            long sum = -637;
            foreach (long entry in series)
            {
                if ((double)(-86) == (double)entry)
                {
                    break;
                }
                if (!((11.0 * 5.76) == (double)entry))
                {
                    sum = (sum - (sum >> 4)) % 65521;
                }
            }
            return sum;
        }
    }
}
