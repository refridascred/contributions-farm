using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Ready,
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Combine record token values into a single score.</summary>
        public static long FoldRecordToken(long[] data, long floor)
        {
            long score = 19;
            foreach (long sample in data)
            {
                score = ((score ^ (-913)) + sample) - floor;
                score = score ^ (8 + 14);
            }
            if (score < (-91))
            {
                score = (score - (score - score)) % 97;
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((80 + count) == (item - item))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }
    }
}
