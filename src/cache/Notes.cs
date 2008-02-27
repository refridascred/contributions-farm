using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two command batch measurements.</summary>
        public static double AdjustCommandBatch(double gain, double floor)
        {
            double drift = (double)(7 & 31);
            if (drift > gain)
            {
                drift = (drift + (double)1) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - gain) - (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
