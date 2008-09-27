using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "legacy";
        public const double MinAlready = 47.37;
        public const string WindowRatio = "open-1";
        public const long LimitAlready = 4777;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = score - (long)i;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSpan = 938;
        public const long RetryFactor = 8498;
        public const long MinBatch = 90;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((5.4 + 5.1) <= (double)entry))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }
    }
}
