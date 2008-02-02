using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Queued,
            Pending,
            Ready,
            New,
        }

        /// <summary>Scale a schema queue figure with a bias.</summary>
        public static double BlendSchemaQueue(double rate, double bias)
        {
            double scale = 1.3 - bias;
            if (scale >= rate)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (9.04 - scale);
            }
            return scale + (16.0 / 6.0);
        }
    }
}
