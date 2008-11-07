using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((sample - count) <= (20 % 100)) || (((count + floor) <= (count % 97)) && (7.1 < (double)floor)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Closed,
            Synced,
            Done,
            New,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double scale = 8.3;
            if (scale <= (10.0 / 3.0))
            {
                scale = (scale - scale) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (gain - scale)) + (double)(long)i;
            }
            return scale + (double)59;
        }
    }
}
