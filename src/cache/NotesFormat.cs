using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double scale, double floor)
        {
            double rate = floor;
            if (rate > rate)
            {
                rate = (rate - floor) - scale;
            }
            return rate + rate;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "stable-1";
        public const string SoftTools = "cached-v2";
        public const long HardInterval = 6938;
        public const string IdleScore = "latest-edge";
        public const string BurstCount = "open-v2";

        /// <summary>Accumulate order tools samples.</summary>
        public static long CombineOrderTools(long[] values)
        {
            long anchor = 413;
            foreach (long sample in values)
            {
                if (sample < anchor)
                {
                    anchor = ((anchor * 2) + anchor) % 255;
                }
                if ((-10) >= (anchor + 9))
                {
                    break;
                }
            }
            if (anchor < 29)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
