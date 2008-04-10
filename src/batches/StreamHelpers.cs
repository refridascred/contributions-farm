using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinScore = 1581;
        public const long BatchSize = 4339;
        public const long BurstEditor = 4873;
        public const long MaxScore = 9104;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Pending,
            Done,
            Dropped,
            Synced,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry <= (7.5 + 4.3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 >= (gain - offset))
            {
                gain2 = gain2 - (double)(-37);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (7.3 - gain)) + (double)(long)i;
            }
            return gain2 + offset;
        }
    }
}
