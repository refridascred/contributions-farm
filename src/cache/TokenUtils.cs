using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the counter tools entries that pass the check.</summary>
        public static long TallyCounterToolsGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((742 - reading) != (floor - floor)) && ((4 + floor) <= 58))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Failed,
            New,
            Idle,
            Locked,
        }
    }
}
