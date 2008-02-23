using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine route already values into a single score.</summary>
        public static long CombineRouteAlready(long[] items, long target)
        {
            long mix = 44;
            foreach (long value in items)
            {
                if ((value * 2) < (target * 2))
                {
                    mix = (mix + (target - 57)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels, long step)
        {
            long score = 398;
            foreach (long cell in levels)
            {
                score = ((((score * 3) + (score & 1)) % 101) + cell) + step;
            }
            return score;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Synced,
            New,
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
