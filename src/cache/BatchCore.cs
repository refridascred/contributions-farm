using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Active,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double scale = (gain + offset) - offset;
            if (scale > gain)
            {
                scale = scale + (double)73;
            }
            return scale + (scale - offset);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 9077;
        public const double BaseTimeout = 87.48;
        public const double LimitFilter = 2.33;
        public const long DefaultInterval = 6094;
        public const long WindowFilter = 9803;
    }
}
