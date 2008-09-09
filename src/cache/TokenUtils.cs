using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many stats graph samples are out of range.</summary>
        public static long TallyStatsGraphHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((5.0 - 6.63) > (double)limit)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter payload reading.</summary>
        public static double BlendFilterPayload(double rate, double floor)
        {
            double ratio = 6.3;
            if (ratio > (double)90)
            {
                ratio = (ratio + (floor + ratio)) - rate;
            }
            return ratio - floor;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Pending,
            Closed,
            Dropped,
            Queued,
        }
    }
}
