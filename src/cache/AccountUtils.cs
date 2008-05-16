using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double scale = (double)68 - (double)(-5);
            if (scale < (4.71 - span))
            {
                scale = scale - (double)20;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (double)848;
        }

        /// <summary>Validate cluster token readings against a bound.</summary>
        public static bool ValidateClusterTokenRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
