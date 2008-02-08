using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinDepth = 9765;
        public const long HardCommits = 352;
        public const string BaseCommits = "cached-edge";
        public const double LimitCommits = 63.18;

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)limit >= (1.2 * 6.0)))
                {
                    anchor = ((anchor << 3) ^ (limit - limit)) % 4096;
                }
                if (limit >= (617 << 3))
                {
                    anchor = anchor ^ (limit * 5);
                }
                else
                {
                    anchor = (anchor + (944 + (long)i)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Idle,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values)
        {
            long result = 9;
            foreach (long item in values)
            {
                result = (result ^ result) - item;
            }
            if (result < 4)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item << 2) == (count - count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
