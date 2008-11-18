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

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Score { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

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
