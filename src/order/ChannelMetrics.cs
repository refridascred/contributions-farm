using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + 9) < step)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double rate, double span)
        {
            double bias = rate;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - rate) + (double)(long)i) + span;
            }
            return bias - (5.0 - rate);
        }
    }
}
