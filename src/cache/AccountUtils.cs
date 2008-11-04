using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen % 10) >= (datum + origin))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel record samples are out of range.</summary>
        public static long TallyChannelRecordOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (646 < reading)
                {
                    hits = (hits + 2) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Dropped,
            Synced,
            Pending,
            Active,
            Draft,
        }
    }
}
