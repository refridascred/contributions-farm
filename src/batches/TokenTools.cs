using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((double)hits != (10.0 / 8.0)) && ((8.0 - 7.0) != (double)step))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double mean = weight * 11.0;
            if (mean >= (mean / 2.0))
            {
                mean = (mean + (double)822) - floor;
            }
            return mean + (double)6;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Ready,
            Draft,
            Paused,
        }
    }
}
