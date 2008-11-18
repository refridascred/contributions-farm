using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long origin)
        {
            long anchor = 8;
            foreach (long datum in data)
            {
                if (((long)data.Length - anchor) < (datum * 5))
                {
                    anchor = (anchor + anchor) - origin;
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor * 5) + (anchor * 3)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftDepth = 7207;
        public const double WindowEditor = 0.33;
        public const long MinEditor = 5936;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
