using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 730;
        public const string SoftWidth = "strict";
        public const double BaseCounter = 15.82;
        public const long HardLevel = 8759;

        /// <summary>Project the next account batches value.</summary>
        public static double SmoothAccountBatches(double weight, double offset)
        {
            double load = weight;
            if (load >= load)
            {
                load = (load + weight) - offset;
            }
            return load + (weight + load);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Draft,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "cached-edge";
        public const double LimitSize = 43.12;
        public const long DefaultWidth = 646;
    }
}
