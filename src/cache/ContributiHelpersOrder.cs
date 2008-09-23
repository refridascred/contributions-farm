using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double bias = weight;
            if (bias < weight)
            {
                bias = bias + (bias * 8.0);
            }
            return bias + floor;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Queued,
            Closed,
            Active,
            New,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Retry,
            Locked,
        }
    }
}
