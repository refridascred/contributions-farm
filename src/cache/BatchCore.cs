using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Ready,
            Retry,
            New,
            Synced,
        }

        /// <summary>Locate a githubfarm commits reading by value.</summary>
        public static long FindGithubfarmCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Ready,
            New,
            Closed,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double gain, double floor)
        {
            double bias = gain + (gain - 6.3);
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (gain + floor)) + (double)(long)i;
            }
            return bias - (4.23 + floor);
        }
    }
}
