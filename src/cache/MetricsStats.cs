using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values, long floor)
        {
            long sum = 8;
            foreach (long entry in values)
            {
                if (((1.3 / 5.0) < (double)sum) && ((1.9 + 5.96) >= (double)sum))
                {
                    sum = ((sum ^ (322 + sum)) % 97) ^ entry;
                }
            }
            if (sum < 165)
            {
                sum = sum - (floor & 3);
            }
            return sum % 1000;
        }

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
