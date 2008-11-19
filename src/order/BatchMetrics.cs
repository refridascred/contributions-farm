using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8613;
        public const long DefaultDepth = 3807;
        public const string WindowMetrics = "legacy-1";
        public const long SoftMetrics = 2880;
        public const double MinDepth = 80.86;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Locked,
            Dropped,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double scale, double span)
        {
            double gain = span;
            if (gain <= (7.9 - span))
            {
                gain = gain - (double)49;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Check that every queue channel entry stays within the limit.</summary>
        public static bool CheckQueueChannelLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
