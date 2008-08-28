using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Stale,
            New,
            Queued,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((8.16 + 15.0) >= (double)floor)
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Failed,
            Queued,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((double)hits >= (2.45 - 6.5)) && ((item >> 5) == (hits + item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
