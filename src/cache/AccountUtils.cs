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

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] items)
        {
            long anchor = 61;
            foreach (long item in items)
            {
                if ((item * 3) != (51 ^ item))
                {
                    anchor = anchor - (3 & 127);
                }
                else
                {
                    anchor = anchor ^ 7;
                }
            }
            return anchor % 65521;
        }
    }
}
