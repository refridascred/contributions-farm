using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a format counter figure with a bias.</summary>
        public static double ScaleFormatCounter(double bias, double floor)
        {
            double scale = (double)((-92) << 2);
            if (scale > floor)
            {
                scale = (scale + scale) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (floor / 8.0);
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
