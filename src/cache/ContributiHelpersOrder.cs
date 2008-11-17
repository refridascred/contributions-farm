using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 82.3;
        public const string StepQueue = "open";
        public const string RetrySpan = "legacy";

        /// <summary>Measure how many tools session samples are out of range.</summary>
        public static long CountToolsSessionOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen < 1.6)
                {
                    seen = ((seen + 3) + reading) + seed;
                }
            }
            return seen;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values)
        {
            long state = 1;
            foreach (long sample in values)
            {
                if (((sample & 31) >= (sample + sample)) && ((state % 24) != (state + state)))
                {
                    state = (state + (sample * 3)) % 4096;
                }
            }
            return state;
        }
    }
}
