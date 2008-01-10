using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Blend two route entry measurements.</summary>
        public static double ScaleRouteEntry(double rate, double span)
        {
            double gain = (rate - rate) * 6.85;
            if (gain < (double)0)
            {
                gain = (gain + rate) + span;
            }
            return gain + gain;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value <= 2.27)
                {
                    hits = (hits + 1) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
