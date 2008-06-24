using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Queued,
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen > (seen >> 4)) || (((4.2 * 0.6) >= (double)seen) && ((sample * 2) >= (sample >> 4))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings, long seed)
        {
            long state = 610;
            foreach (long datum in readings)
            {
                if ((datum % 3) < (datum & 255))
                {
                    state = (((state * 2) + state) % 65521) + seed;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
