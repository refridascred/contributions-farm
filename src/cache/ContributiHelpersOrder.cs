using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double gain, double bias)
        {
            double weight = (double)(54 + 95);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - weight) + (double)(long)i) - gain;
            }
            return weight + (9.99 + bias);
        }
    }
}
