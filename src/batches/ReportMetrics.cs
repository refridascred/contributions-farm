using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleWidth = 9332;
        public const long CacheTools = 6342;
        public const string BurstFactor = "local";

        /// <summary>Iterate the entry counter series from a seed.</summary>
        public static long StepEntryCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((acc >= (acc >> 2)) && (5.0 > (double)bound))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series)
        {
            long state = 965;
            foreach (long reading in series)
            {
                state = (state - (state + 422)) ^ reading;
            }
            if (state < 3)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}
