using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading * 3) >= seen) && ((seen << 2) == ((-40) & 31)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) <= (matches << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Closed,
            Synced,
        }
    }
}
