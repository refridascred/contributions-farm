using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Done,
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Project the next commits farm value.</summary>
        public static double ScaleCommitsFarm(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (floor * 20.0)) + (double)(long)i) + weight;
            }
            return mean - floor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
