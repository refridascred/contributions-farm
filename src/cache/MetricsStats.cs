using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitInterval = 1431;
        public const long BurstCommits = 4240;
        public const double SoftCount = 86.57;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            New,
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Count the buffer notes entries that pass the check.</summary>
        public static long CountBufferNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count > (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading & 7) <= (19 - hits))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
