using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a farm profile reading.</summary>
        public static double ScaleFarmProfile(double gain, double offset)
        {
            double ratio = offset;
            if (ratio >= (ratio / 6.0))
            {
                ratio = (ratio + (double)2) - gain;
            }
            else
            {
                ratio = ratio + (double)39;
            }
            return ratio - offset;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Locked,
            Synced,
        }
    }
}
