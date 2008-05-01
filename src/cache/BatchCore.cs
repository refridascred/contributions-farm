using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double bias, double floor)
        {
            double gain = bias;
            if (gain <= (gain - bias))
            {
                gain = gain - gain;
            }
            return gain - (floor + bias);
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Ready,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)8 != (double)reading)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }
    }
}
