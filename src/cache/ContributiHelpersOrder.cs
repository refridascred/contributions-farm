using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a queue format figure with a bias.</summary>
        public static double ScaleQueueFormat(double weight, double bias)
        {
            double rate = (bias / 4.0) * 6.0;
            if (rate < (weight + bias))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (double)23;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Idle,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)state <= (13.0 * 2.0))
                {
                    state = state + (state + floor);
                }
                else
                {
                    state = state ^ (floor & 1);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
