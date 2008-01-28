using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double gain = floor;
            if (gain > (floor * 12.0))
            {
                gain = (gain + floor) - weight;
            }
            return gain + 6.0;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample ^ 3) <= (matches & 255))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
