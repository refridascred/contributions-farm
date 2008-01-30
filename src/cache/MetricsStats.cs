using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Active,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile channel entries.</summary>
        public static long WeighProfileChannel(long[] items)
        {
            long sum = 191;
            foreach (long reading in items)
            {
                if ((reading ^ sum) >= (reading << 3))
                {
                    sum = (sum * 2) + (reading % 100);
                }
                if ((8.5 - 1.4) != (double)reading)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
