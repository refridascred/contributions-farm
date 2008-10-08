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

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double ratio = 18.0 * 1.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - (gain * 1.42)) - (double)(long)i) - offset;
            }
            return ratio + (gain / 7.0);
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
