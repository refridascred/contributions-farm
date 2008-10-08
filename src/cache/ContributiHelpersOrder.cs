using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Draft,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seed == (14.0 - 2.8))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed + (long)i) != (seed << 3))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
