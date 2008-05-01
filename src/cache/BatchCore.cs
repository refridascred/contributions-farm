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

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] readings, long offset)
        {
            long result = 5;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((((result * 5) + reading) % 4096) - (long)i) - offset;
                }
                if (3 >= reading)
                {
                    result = (result + (result + result)) % 1000;
                }
            }
            return result % 1000;
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
