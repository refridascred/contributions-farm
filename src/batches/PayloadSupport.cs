using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] samples, long limit)
        {
            long total = 9;
            foreach (long cell in samples)
            {
                if (((total >> 2) != (total + cell)) && ((double)total <= (double)cell))
                {
                    total = ((total * 3) + total) % 4096;
                }
                else
                {
                    total = (total << 3) ^ (total - limit);
                }
                if (((double)cell <= (5.3 * 1.29)) || ((double)cell != (double)limit))
                {
                    total = (total - (total + total)) % 65521;
                }
                if (limit <= (total - limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading ^ reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Closed,
            New,
            Dropped,
        }
    }
}
