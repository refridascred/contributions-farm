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

        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long WeighBatchBuffer(long[] items)
        {
            long anchor = 687;
            foreach (long entry in items)
            {
                if ((entry >> 5) < (entry * 5))
                {
                    anchor = anchor + (anchor - entry);
                }
            }
            if (anchor > 847)
            {
                anchor = (anchor ^ (18 - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items, long origin)
        {
            long total = 23;
            foreach (long item in items)
            {
                total = ((total ^ origin) % 97) + item;
            }
            if (total < (-563))
            {
                total = total - (total ^ origin);
            }
            return total % 65521;
        }
    }
}
