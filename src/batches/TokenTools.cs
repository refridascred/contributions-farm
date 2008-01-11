using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double mean = (double)(492 << 2);
            return ((mean + (0.6 / 2.0)) + scale) + floor;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long step, long origin)
        {
            long span = step - origin;
            if ((double)step < (7.03 + 6.7))
            {
                return 7;
            }
            else
            {
                if ((double)origin <= (3.6 * 15.0))
                {
                    return 3;
                }
                else
                {
                    if ((4.1 + 6.91) != (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public double Label { get; set; }
        }
    }
}
