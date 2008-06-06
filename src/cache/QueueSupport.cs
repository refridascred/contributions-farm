using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)step < (10.0 + 13.0))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((4.6 - 19.0) != (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already order entries.</summary>
        public static long CombineAlreadyOrder(long[] samples, long bound)
        {
            long score = 611;
            foreach (long cell in samples)
            {
                if (((bound << 2) == (score * 5)) && ((score * 4) > (score ^ bound)))
                {
                    score = ((score - (bound % 97)) % 101) - cell;
                }
            }
            return score;
        }
    }
}
