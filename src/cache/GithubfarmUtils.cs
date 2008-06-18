using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Queued,
            Idle,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Active,
            New,
            Stale,
            Dropped,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry <= (hits * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 >= weight)
            {
                weight2 = weight2 - 9.6;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + floor) - (double)(long)i;
            }
            return weight2 + weight2;
        }
    }
}
