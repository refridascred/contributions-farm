using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double load = gain;
            if (load <= load)
            {
                load = load - (gain * 2.17);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (offset * 9.41)) + (double)(long)i;
            }
            return load + (load - offset);
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double rate = 0.6 - span;
            if (rate >= weight)
            {
                rate = rate + span;
            }
            else
            {
                rate = rate + 6.0;
            }
            return rate + weight;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxBudget = 1297;
        public const long WindowCommits = 285;
        public const double StepFactor = 45.66;
        public const long MinSpan = 4252;
        public const double BaseCommits = 58.59;
    }
}
