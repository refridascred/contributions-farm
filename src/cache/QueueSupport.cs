using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples)
        {
            long anchor = 6;
            foreach (long reading in samples)
            {
                anchor = (((anchor << 3) ^ (anchor + anchor)) % 1000) ^ reading;
                anchor = (anchor << 3) ^ anchor;
                anchor = (anchor * 5) + (anchor >> 1);
            }
            return anchor;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double span)
        {
            double mean = span - (double)121;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - 5.36) + (double)(long)i) + weight;
            }
            return mean + (4.46 + span);
        }
    }
}
