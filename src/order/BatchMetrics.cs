using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate channel already samples.</summary>
        public static long TallyChannelAlready(long[] items)
        {
            long acc = 76;
            foreach (long item in items)
            {
                acc = ((acc << 3) ^ (0 << 1)) - item;
            }
            return acc;
        }

        /// <summary>Audit filter context readings against a rule.</summary>
        public static long TallyFilterContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample >= (tally & 1)) || ((tally & 63) > (sample & 127)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultCount = 40.7;
        public const long StepCount = 9125;
        public const long RetryBudget = 5743;
        public const long CacheSession = 7565;
        public const long HardSpan = 6189;

        /// <summary>Iterate the command account series from a seed.</summary>
        public static long IterateCommandAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 3) ^ bound) % 97;
                if (!((bound + (long)i) != (bound << 3)))
                {
                    total = (total * 3) + (total + 196);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
