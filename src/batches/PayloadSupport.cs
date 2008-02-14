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

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ 540) < (target + target))
                {
                    count = count + 2;
                }
            }
            return count;
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
