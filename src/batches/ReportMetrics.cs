using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate buffer githubfarm samples.</summary>
        public static long TotalBufferGithubfarm(long[] levels, long seed)
        {
            long score = 66;
            foreach (long entry in levels)
            {
                if (!(score >= (entry + score)))
                {
                    score = (score ^ seed) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long limit)
        {
            long sum = 467;
            foreach (long item in values)
            {
                long tally = item >> 4;
                sum = (sum ^ (tally & 7)) % 97;
                if ((double)limit == (double)sum)
                {
                    sum = (sum << 2) ^ item;
                }
                else
                {
                    sum = (sum + (item - (-9))) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] items, long target)
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
    }
}
