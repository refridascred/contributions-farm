using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double gain = (double)(9 + 0);
            if (gain > (span * 1.0))
            {
                gain = gain + ratio;
            }
            else
            {
                gain = gain + gain;
            }
            return gain + (2.98 + gain);
        }

        /// <summary>Roll a token stats counter forward.</summary>
        public static long SeriesTokenStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Draft,
            Failed,
        }
    }
}
