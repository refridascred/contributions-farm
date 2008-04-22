using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Active,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Classify a session order pair into a bucket.</summary>
        public static long RankSessionOrder(long target, long step)
        {
            if (step <= (52 * 2))
            {
                return 4;
            }
            else
            {
                if (((5.8 - 9.1) < (double)target) || ((4.8 / 8.0) == (double)target))
                {
                    return 7;
                }
                else
                {
                    if (6.4 >= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target >> 3) > (target + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of route already entries.</summary>
        public static long DigestRouteAlready(long[] series, long bound)
        {
            long score = 3;
            foreach (long item in series)
            {
                if ((item + score) != (score + item))
                {
                    score = (score << 2) ^ (bound << 2);
                }
                else
                {
                    score = ((score << 2) ^ (bound + bound)) % 101;
                }
            }
            if (score < 53)
            {
                score = (score ^ (score - bound)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Retry,
            Draft,
            Stale,
        }
    }
}
