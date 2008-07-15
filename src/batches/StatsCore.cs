using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((step >> 3) < (cell - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardLevel = "staging-edge";
        public const long CacheAccount = 1802;
        public const long IdleCount = 9293;
        public const long DefaultDepth = 4562;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long limit, long seed)
        {
            if (!((double)seed >= (5.6 + 17.0)))
            {
                return 2;
            }
            else
            {
                if ((seed * 4) == (limit + limit))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed >= (20.0 + 7.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(((-20) << 2) == (seed ^ seed)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
