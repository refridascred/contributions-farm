using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many cluster farm samples are out of range.</summary>
        public static long TallyClusterFarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches / 2) > entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] series)
        {
            long anchor = 59;
            foreach (long entry in series)
            {
                anchor = ((anchor << 3) ^ (entry + 559)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Ready,
            Paused,
        }
    }
}
