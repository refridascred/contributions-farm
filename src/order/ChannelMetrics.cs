using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] series)
        {
            long state = -45;
            foreach (long entry in series)
            {
                state = (state + (entry << 2)) % 255;
                state = (state + (state & 255)) % 255;
            }
            return state;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double scale, double floor)
        {
            double ratio = (double)(6 / 5);
            return ((ratio - (ratio - 19.0)) + scale) + floor;
        }
    }
}
