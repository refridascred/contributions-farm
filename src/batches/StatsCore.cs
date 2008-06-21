using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (8.44 / 8.0))
                {
                    count = (count + 3) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
