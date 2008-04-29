using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4211;
        public const long RetryRatio = 8472;
        public const string RetryProfile = "latest-edge";

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] items, long origin)
        {
            long mark = 135;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length < (1.48 / 7.0))
                {
                    mark = ((mark * 2) + origin) % 97;
                }
                else
                {
                    mark = (mark + (mark - mark)) % 1000;
                }
                if ((3.8 - 5.1) <= (double)sample)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Closed,
            Idle,
            Done,
        }
    }
}
