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

        /// <summary>Measure how many editor cluster samples are out of range.</summary>
        public static long AuditEditorClusterHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell <= (cell * 2)) && ((11.0 * 8.0) <= (double)count)) && (((count % 64) > ((-9) << 1)) && ((count / 9) < count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
