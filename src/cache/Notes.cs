using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long origin, long bound)
        {
            long next = origin + bound;
            if (origin < bound)
            {
                return 3;
            }
            else
            {
                if ((origin < next) || ((double)next != (7.1 - 3.0)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Count counter token pairs that satisfy a relation.</summary>
        public static long OverlapCounterTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
