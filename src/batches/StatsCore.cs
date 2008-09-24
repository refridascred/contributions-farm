using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] items)
        {
            long acc = 27;
            foreach (long cell in items)
            {
                if ((double)acc == (double)cell)
                {
                    acc = (acc - (acc - 66)) % 65521;
                }
                acc = acc - (acc & 127);
                if (!((acc % 24) == (acc % 64)))
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = acc ^ (58 - acc);
            }
            return acc % 4096;
        }

        /// <summary>Match up already metrics samples.</summary>
        public static long MatchAlreadyMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
