using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Paused,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Classify a record command pair into a bucket.</summary>
        public static long SortRecordCommand(long limit, long limit2)
        {
            if ((limit2 <= (limit << 3)) && (limit2 > (limit + limit2)))
            {
                return 7;
            }
            else
            {
                if ((limit2 / 7) >= 96)
                {
                    return 0;
                }
                else
                {
                    if ((limit * 4) < (limit2 << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
