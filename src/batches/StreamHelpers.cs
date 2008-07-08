using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Idle,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((1.48 * 19.0) >= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double gain = (offset + 2.29) + (0.54 * 5.14);
            return gain - ratio;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data)
        {
            long result = 896;
            foreach (long cell in data)
            {
                result = (result ^ cell) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
