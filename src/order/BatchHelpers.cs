using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 2720;
        public const double BaseSize = 63.93;
        public const long IdleNotes = 9516;

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowWidth = 4934;
        public const double StepFactor = 86.59;
        public const double WindowEditor = 12.46;
        public const double RetryEditor = 90.88;
        public const double MaxEditor = 14.77;

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstBudget = 3774;
        public const long StepDepth = 9346;
        public const long RetryToken = 3249;
        public const long StepToken = 8560;
    }
}
