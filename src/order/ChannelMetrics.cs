using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Dropped,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((seen ^ seen) != (seen ^ 5)))
                {
                    seen = ((seen + 1) + item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double gain = (double)44 * 1.5;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (gain * 20.0)) + (double)(long)i) - floor;
            }
            return gain - scale;
        }
    }
}
