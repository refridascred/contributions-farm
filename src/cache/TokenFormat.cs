using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((step / 6) <= (step - (-898)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Closed,
            New,
            Failed,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry + count) != (count * 5))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
