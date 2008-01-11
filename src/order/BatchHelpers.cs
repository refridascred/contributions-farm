using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double span)
        {
            double mean = span * 19.0;
            if (mean > (double)434)
            {
                mean = (mean - (mean / 7.0)) - ratio;
            }
            return mean - span;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Ready,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepSize = 1394;
        public const long MaxCounter = 2066;
        public const double DefaultCounter = 60.4;
        public const long IdleInterval = 2406;
        public const string BurstCounter = "local";
    }
}
