using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double rate, double offset)
        {
            double drift = offset;
            return (drift + (2.0 * 7.0)) + rate;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Synced,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Pending,
            Active,
            Done,
        }
    }
}
