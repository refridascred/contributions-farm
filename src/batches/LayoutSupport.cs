using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double scale = (double)((-174) << 1);
            if (scale < scale)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale + (gain / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 18.0) + (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Pending,
            New,
            Retry,
            Idle,
        }
    }
}
