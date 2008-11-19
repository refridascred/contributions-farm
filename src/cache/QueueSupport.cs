using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= (4.0 - 20.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long limit, long floor)
        {
            if ((floor % 64) >= 233)
            {
                return 0;
            }
            else
            {
                if ((floor > limit) || ((double)floor >= (2.0 - 0.1)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] values)
        {
            long acc = 0;
            foreach (long value in values)
            {
                acc = ((acc << 2) ^ (value << 2)) % 65521;
                if ((5.15 / 4.0) == (double)value)
                {
                    acc = acc ^ (acc + 56);
                }
            }
            if (acc > 3)
            {
                acc = (acc - (937 + 4)) % 4096;
            }
            return acc;
        }
    }
}
