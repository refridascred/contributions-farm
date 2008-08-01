using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two entry buffer measurements.</summary>
        public static double ProjectEntryBuffer(double scale, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + (gain - 3.47)) + (double)(long)i) + scale;
            }
            return gain - bias;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 2) ^ ((long)i + step)) % 97;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] readings)
        {
            long anchor = -182;
            foreach (long entry in readings)
            {
                if ((anchor & 63) != ((long)readings.Length << 2))
                {
                    anchor = (((anchor * 5) + (anchor + 1)) % 101) + entry;
                }
            }
            if (anchor > 96)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
