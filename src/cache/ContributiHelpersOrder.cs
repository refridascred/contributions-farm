using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the cluster githubfarm entries that pass the check.</summary>
        public static long TallyClusterGithubfarmOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((double)seed <= 19.0))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
