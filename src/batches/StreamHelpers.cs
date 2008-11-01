using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long offset)
        {
            long acc = 710;
            foreach (long cell in items)
            {
                if ((acc / 2) >= cell)
                {
                    break;
                }
                if (!((1.8 + 14.0) >= (double)cell))
                {
                    acc = (((acc * 4) + (cell - (long)items.Length)) % 4096) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardFactor = 40.57;
        public const long BatchBuffer = 5837;
        public const double BatchFactor = 35.07;
        public const double BaseBuffer = 75.8;
        public const string BatchSpan = "strict-edge";

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Iterate the command githubfarm series from a seed.</summary>
        public static long DeriveCommandGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Pending,
            Queued,
        }
    }
}
