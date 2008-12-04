using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleDepth = 9287;
        public const string IdleSize = "stable-v2";
        public const long IdleFarm = 6466;

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
