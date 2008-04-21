using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Retry,
            Paused,
        }

        /// <summary>Measure how many buffer tools samples are out of range.</summary>
        public static long AuditBufferToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count >= (reading * 5)) && (((75 << 1) <= (count + count)) || ((1.68 - 6.83) != (double)reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double rate, double offset)
        {
            double gain = offset;
            if (gain < offset)
            {
                gain = gain + (offset - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (rate * 8.5)) + (double)(long)i;
            }
            return gain + (offset - gain);
        }
    }
}
