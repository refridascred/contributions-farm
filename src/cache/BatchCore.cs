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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
