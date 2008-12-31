using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9466;
        public const double HardScore = 82.73;
        public const long MinFormat = 3517;
        public const long StepFactor = 9706;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Grade a context report value against two limits.</summary>
        public static long GradeContextReport(long seed, long step)
        {
            if (!(18.0 <= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((1.9 / 3.0) == (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step + step) != (seed - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of context cache readings.</summary>
        public static long CompareContextCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Queued,
            Retry,
            New,
        }
    }
}
