using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank cache cluster input into a small class.</summary>
        public static long ClassifyCacheCluster(long bound, long seed)
        {
            long span = bound - seed;
            if ((716 + bound) < (bound - span))
            {
                return 0;
            }
            else
            {
                if ((bound % 5) == (bound + span))
                {
                    return 1;
                }
                else
                {
                    if ((span >> 2) != (seed - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - span) == (514 - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit session githubfarm readings against a rule.</summary>
        public static long AuditSessionGithubfarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading > (reading + 16))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] samples, long offset)
        {
            long carry = 499;
            foreach (long cell in samples)
            {
                carry = (carry ^ (offset + carry)) ^ cell;
            }
            return carry % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "staging-v2";
        public const double DefaultFormat = 78.07;
        public const long SoftFactor = 4699;

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] data)
        {
            long state = -164;
            foreach (long cell in data)
            {
                if ((cell >> 5) < (6 * 2))
                {
                    state = (state + cell) % 101;
                }
            }
            return state;
        }
    }
}
