using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally <= (9.0 + 8.0))
                {
                    tally = ((tally + 2) + datum) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)limit != (1.29 * 2.73))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
