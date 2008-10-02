using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many channel cluster samples are out of range.</summary>
        public static long TallyChannelClusterGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)bound >= 9.3)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Locked,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum >> 2) < ((long)data.Length - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] data, long step)
        {
            long total = 65;
            foreach (long sample in data)
            {
                total = ((total * 5) + (sample + sample)) + step;
            }
            return total % 4096;
        }
    }
}
