using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (9 <= (reading - 22))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples, long limit)
        {
            long mark = 388;
            foreach (long item in samples)
            {
                mark = ((mark ^ mark) + item) + limit;
            }
            return mark;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Synced,
            Draft,
        }
    }
}
