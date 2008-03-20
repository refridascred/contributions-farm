using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Active,
            Locked,
        }

        /// <summary>Project the next layout graph value.</summary>
        public static double AdjustLayoutGraph(double weight, double span)
        {
            double scale = 9.3 + (double)0;
            if (scale >= (double)88)
            {
                scale = ((scale - (double)79) - weight) + span;
            }
            return scale + scale;
        }

        /// <summary>Look up the position of a order channel sample.</summary>
        public static long SeekOrderChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
