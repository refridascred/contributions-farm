using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double weight, double span)
        {
            double ratio = (weight * 8.0) * 19.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (ratio / 3.0)) + (double)(long)i;
            }
            return ratio + (span / 7.0);
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Done,
            Paused,
        }
    }
}
