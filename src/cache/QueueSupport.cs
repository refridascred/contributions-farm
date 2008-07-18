using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Active,
            Pending,
            Failed,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Synced,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Scale a githubfarm queue figure with a bias.</summary>
        public static double SmoothGithubfarmQueue(double scale, double floor)
        {
            double weight = scale;
            if (weight < (double)761)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (floor * 9.4);
            }
            return weight + weight;
        }
    }
}
