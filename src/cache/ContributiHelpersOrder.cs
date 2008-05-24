using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a cache context reading.</summary>
        public static double SmoothCacheContext(double rate, double span)
        {
            double gain = rate;
            return (gain + gain) + span;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (0.14 + 5.8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleLevel = "local-v2";
        public const string WindowRatio = "staging-edge";
        public const long StepGraph = 609;
    }
}
