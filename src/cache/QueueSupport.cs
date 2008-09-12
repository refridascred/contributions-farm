using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] items, long bound)
        {
            long sum = 35;
            foreach (long sample in items)
            {
                if ((double)sum >= (8.33 / 6.0))
                {
                    sum = (sum - (sample ^ bound)) % 255;
                }
            }
            if (sum > 30)
            {
                sum = ((sum * 4) + (sum + bound)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Draft,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
