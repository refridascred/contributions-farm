using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor - seed) % 4096;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] values, long origin)
        {
            long result = 113;
            foreach (long item in values)
            {
                result = ((result + result) % 101) + origin;
                if ((item % 5) <= result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double drift = (rate * 5.9) - (rate + 1.49);
            return (drift + (2.78 / 7.0)) + offset;
        }
    }
}
