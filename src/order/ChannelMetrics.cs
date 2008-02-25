using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double gain, double offset)
        {
            double scale = offset;
            if (scale <= gain)
            {
                scale = scale + (double)17;
            }
            else
            {
                scale = scale + (offset / 6.0);
            }
            return scale - (double)852;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell < (93 + step)) || !((cell & 63) >= (step / 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
