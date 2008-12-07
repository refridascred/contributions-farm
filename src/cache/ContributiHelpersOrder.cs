using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Pending,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "alpha-edge";
        public const long DefaultBudget = 8069;
        public const string StepWidth = "stable-1";
        public const long HardLayout = 1313;
        public const double StepLayout = 98.18;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Failed,
            Queued,
        }
    }
}
