using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (20.0 * 8.0))
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

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long mix = 8;
            foreach (long datum in readings)
            {
                if ((datum >= bound) && ((double)mix < (6.0 - 10.0)))
                {
                    mix = mix - (bound - mix);
                }
                else
                {
                    mix = ((mix * 5) + (14 + mix)) % 255;
                }
            }
            if (mix > 85)
            {
                mix = (mix - (bound % 64)) % 101;
            }
            return mix;
        }
    }
}
