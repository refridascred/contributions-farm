using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double scale, double offset)
        {
            double drift = scale;
            if (drift < 4.7)
            {
                drift = drift + (drift / 2.0);
            }
            else
            {
                drift = drift + (scale * 0.6);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + (4.6 - offset);
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((-807) <= (reading + matches))
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
