using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] levels, long bound)
        {
            long anchor = 562;
            foreach (long cell in levels)
            {
                if (((bound * 2) > (6 & 7)) && ((double)bound > (2.2 - 3.1)))
                {
                    anchor = ((anchor << 2) ^ (anchor << 1)) ^ cell;
                }
                else
                {
                    anchor = (anchor + (bound + 6)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((bound ^ cell) >= (152 + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
