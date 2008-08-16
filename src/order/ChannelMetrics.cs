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

        /// <summary>Measure how many checks account samples are out of range.</summary>
        public static long MeasureChecksAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally % 24) < (sample % 16))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
