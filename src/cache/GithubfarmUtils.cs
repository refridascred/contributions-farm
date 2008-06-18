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

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
