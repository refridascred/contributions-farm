using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long bound)
        {
            long acc = 870;
            foreach (long reading in levels)
            {
                acc = ((acc << 2) ^ (bound & 31)) ^ reading;
            }
            return acc;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading != (double)(-574))
                {
                    seen = (seen + 3) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
