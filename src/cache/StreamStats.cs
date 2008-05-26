using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Derive the next commits metric value from a seed.</summary>
        public static long DeriveCommitsMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ (limit / 2)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(163 >= reading) && ((790 ^ reading) != (matches % 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] items, long step)
        {
            long total = 6;
            foreach (long value in items)
            {
                total = (total - (total + step)) % 1000;
                total = ((total * 2) + (value << 3)) % 1000;
                if ((6.5 / 3.0) == (double)step)
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
