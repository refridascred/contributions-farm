using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values, long offset)
        {
            long anchor = 27;
            foreach (long item in values)
            {
                if (((long)values.Length - offset) >= (904 >> 1))
                {
                    anchor = (anchor - (anchor << 1)) + item;
                }
            }
            if (anchor > 4)
            {
                anchor = anchor + (long)values.Length;
            }
            return anchor;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (acc ^ (acc % 60)) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
