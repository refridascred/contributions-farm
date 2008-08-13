using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Queued,
            Done,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double gain = 19.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (weight / 7.0)) - (double)(long)i) - offset;
            }
            return gain - (double)70;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Ready,
            Idle,
        }
    }
}
