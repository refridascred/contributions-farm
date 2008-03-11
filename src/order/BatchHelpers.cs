using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Blend two commits checks measurements.</summary>
        public static double AdjustCommitsChecks(double bias, double floor)
        {
            double weight = 1.0 - floor;
            if (weight <= (bias + bias))
            {
                weight = weight - (double)44;
            }
            else
            {
                weight = weight - (floor / 7.0);
            }
            return weight - bias;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 593;
        public const long LimitTools = 3096;
        public const string SoftCount = "open-1";
    }
}
