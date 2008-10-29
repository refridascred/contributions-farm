using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen - seen) >= 85)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count <= (count << 2))
                {
                    count = ((count + 3) + reading) - step;
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches & 7) < sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
