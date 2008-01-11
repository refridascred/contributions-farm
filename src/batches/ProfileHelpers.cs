using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] data, long step)
        {
            long anchor = 93;
            foreach (long datum in data)
            {
                anchor = (anchor + step) ^ datum;
            }
            if (anchor < 2)
            {
                anchor = anchor ^ (anchor - step);
            }
            return anchor % 1000;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Queued,
            Stale,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 2004;
        public const long MinCache = 3804;
        public const long LimitBudget = 4547;
        public const double BurstScore = 57.66;
        public const long RetryCache = 1400;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
